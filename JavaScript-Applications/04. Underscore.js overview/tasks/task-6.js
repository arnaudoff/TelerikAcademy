function solve() {
    return function (books) {
        if (!books || !(books instanceof Array)) {
            throw new Error('The function expects an array of books!');
        }

        var authors = _.chain(books)
        .groupBy(function (book) {
            return book.author.firstName + ' ' + book.author.lastName;
        })
        .sortBy('length')
        .map(function (group) {
            return {
                name: group[0].author.firstName + ' ' + group[0].author.lastName,
                books: group.length
            };
        });

        var mostBooks = authors.last().value().books;

        authors.filter(function (author) {
            return author.books === mostBooks;
        })
        .sortBy('name')
        .pluck('name')
        .each(console.log);
    };
}

module.exports = solve;
