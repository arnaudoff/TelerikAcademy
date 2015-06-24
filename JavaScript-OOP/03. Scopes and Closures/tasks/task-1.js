/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/

function solve() {
	var library = (function () {
		var books = [],
			categories = [];
            booksIDCount = 0;
            categoryIDCount = 0;

		function Book(book) {
			if (typeof book.title !== 'string' || book.title.length < 2 || book.title.length > 100) {
				throw 'The title must be a string with length between 2 and 100 characters.';
			}
			if (typeof book.author !== 'string' || book.author === '') {
				throw 'The author of the book must be a non-empty string.';
			}
			if (typeof book.isbn !== 'string' || book.isbn.length !== 10 && book.isbn.length !== 13) {
				throw 'ISBN must be a string with length exactly 10 or 13 digits.';
			}

			this.ID = ++booksIDCount;
			this.title = book.title;
			this.author = book.author;
			this.category = book.category;
			this.isbn = book.isbn;
		}

		function Category(name) {
			if (typeof name !== 'string' || name.length < 2 || name.length > 100) {
				throw 'The name of the category must be with length between 2 and 100 characters.';
			}

			this.ID = ++categoryIDCount;
			this.name = name;
			this.books = [];
		}

		function addBook(book) {
			var newBook,
				newCategory,
				categoryIndex;

			if (books.some(function (item) {
				return (item.title === book.title ||
					item.isbn === book.isbn);
			})) {
				throw 'The title or the ISBN of the given book already exist.';
			} else {
				newBook = new Book(book);
				books.push(newBook);
			}

			if (!categories.some(function (category, currentIndex) {
					categoryIndex = currentIndex; // save it to access it later on
					return category.name === book.category;
				})) {
				newCategory = new Category(book.category);
				newCategory.books.push(newBook);
				categories.push(newCategory);
			} else {
				categories[categoryIndex].books.push(newBook);
			}

			return newBook;
		}

		function listCategories() {
			return categories.sort(function (first, second) {
				return first.id - second.id;
			})
			.map(function (category) {
				category = category.name;
				return category;
			});
		}

		function listBooks(property) {
			var tempBooks = books.slice();
			if (property) {
				for (var prop in property) {
					if (property.hasOwnProperty(prop)) {
						tempBooks = tempBooks.filter(function (item) {
							return item[prop] === property[prop];
						});
					}
				}
			}

			return tempBooks.sort(function (first, second) {
				return first.id - second.id;
			});
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}

module.exports = solve;
