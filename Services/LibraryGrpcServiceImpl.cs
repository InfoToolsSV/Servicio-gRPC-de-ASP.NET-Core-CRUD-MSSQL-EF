using Grpc.Core;
using LibraryGrpcService.Protos;
using LibraryGrpcService.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryGrpcService.Services
{
    public class LibraryGrpcServiceImpl : LibraryService.LibraryServiceBase
    {
        private readonly LibraryContext _context;

        public LibraryGrpcServiceImpl(LibraryContext context)
        {
            _context = context;
        }

        public override async Task<CreateBookResponse> CreateBook(CreateBookRequest request, ServerCallContext context)
        {
            var book = new Models.Book
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.Book.Title,
                Author = request.Book.Author,
                Genre = request.Book.Genre,
                PublicationYear = request.Book.PublicationYear
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return new CreateBookResponse { Id = book.Id };
        }

        public override async Task<GetBookResponse> GetBook(GetBookRequest request, ServerCallContext context)
        {
            var book = await _context.Books.FindAsync(request.Id);

            if (book == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Book not found."));
            }

            return new GetBookResponse
            {
                Book = new Book
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Genre = book.Genre,
                    PublicationYear = book.PublicationYear
                }
            };
        }

        public override async Task<UpdateBookResponse> UpdateBook(UpdateBookRequest request, ServerCallContext context)
        {
            var book = await _context.Books.FindAsync(request.Book.Id);

            if (book == null)
            {
                return new UpdateBookResponse { Success = false };
            }

            book.Title = request.Book.Title;
            book.Author = request.Book.Author;
            book.Genre = request.Book.Genre;
            book.PublicationYear = request.Book.PublicationYear;

            await _context.SaveChangesAsync();

            return new UpdateBookResponse { Success = true };

        }

        public override async Task<DeleteBookResponse> DeleteBook(DeleteBookRequest request, ServerCallContext context)
        {
            var book = await _context.Books.FindAsync(request.Id);

            if (book == null)
            {
                return new DeleteBookResponse { Success = false };
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return new DeleteBookResponse { Success = true };
        }

        public override async Task<ListBooksResponse> ListBooks(ListBooksRequest request, ServerCallContext context)
        {
            var book = await _context.Books.ToListAsync();

            var response = new ListBooksResponse();
            response.Books.AddRange(book.Select(x => new Book
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Genre = x.Genre,
                PublicationYear = x.PublicationYear
            }
            ));

            return response;
        }


    }
}