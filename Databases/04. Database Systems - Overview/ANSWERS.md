### What database models do you know?

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.

- **Hierarchical** - A hierarchical database model is a data model in which the data is organized into a tree-like structure. The data is stored as records which are connected to one another through links. A record is a collection of fields, with each field containing only one value. The entity type of a record defines which fields the record contains.
- **Network model** - The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
- **Relational model** - In the relational model of a database, all data is represented in terms of tuples, grouped into relations. A database organized in terms of the relational model is a relational database. The purpose of the relational model is to provide a declarative method for specifying data and queries: users directly state what information the database contains and what information they want from it, and let the database management system software take care of describing data structures for storing the data and retrieval procedures for answering queries.
- **Object-oriented model** - An object database (also object-oriented database management system) is a database management system in which information is represented in the form of objects as used in object-oriented programming. Object databases are different from relational databases which are table-oriented. Object-relational databases are a hybrid of both approaches.

### Which are the main functions performed by a Relational Database Management System (RDBMS)?

Relational Database Management Systems (RDBMS) manage the data stored in tables. They typically support CRUD operations on tables and relationships between them, as well as searching/indexing etc. They support the SQL language and optionally implement transactions. Popular examples of RDBMS are Microsoft SQL Server, MySQL, Oracle Database, PostgreSQL, SQLite and many more.

### Define what is "table" in database terms.

A table is a collection of related data held in a structured format within a database into rows and columns. It can be used to both store and display data in a structured format. For example, databases store data in tables so that information can be quickly accessed from specific rows.

In relational databases and flat file databases, a table is a set of data elements. A table has a specified number of **constrained columns**, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key. The table is another term for *relation* in RDBMS.

### Explain the difference between a primary and a foreign key.

Primary key is a **column of the table that uniquely identifies a record**, therefore two records are different **if and only if their primary keys are different**. The foreign key, on the other hand, is identifies a record **located in another table** (usually its primary key).

### Explain the different kinds of relationships between tables in relational databases.

- One-to-many – a **country** has many **towns**.
- Many-to-many – a **student** can attend more than one **course**, and one **course** can be attended by more than one **student**; implemented through additional table
- One-to-one – one **husband** has one **wife** and one **wife** has one **husband**

### When is a certain database schema normalized?

A certain database is normalized when it contains repeating data. Basically, the DRY principle applied to a databases – if a table contains columns that have repetitions in some form, extract them to separate tables, defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

Advantages of normalized databases include, but are not limited to the following:

- Better performance, complex queries are easily handled
- Flexible and maintainable
- Better understanding of the data, close modeling of real world entities

### What are database integrity constraints and when are they used?

Data integrity refers to maintaining and assuring the accuracy and consistency of data over its entire life-cycle, and is a critical aspect to the design, implementation and usage of any system which stores, processes, or retrieves data. The term data integrity is broad in scope and may have widely different meanings depending on the specific context.

Types of integrity constraints:

- **Entity integrity** concerns the concept of a primary key. Entity integrity is an integrity rule which states that every table must have a primary key and that the column or columns chosen to be the primary key should be unique and not null.
- **Referential integrity** concerns the concept of a foreign key. The referential integrity rule states that any foreign-key value can only be in one of two states. The usual state of affairs is that the foreign-key value refers to a primary key value of some table in the database. Occasionally, and this will depend on the rules of the data owner, a foreign-key value can be null. In this case we are explicitly saying that either there is no relationship between the objects represented in the database or that this relationship is unknown.
- **Domain integrity** specifies that all columns in a relational database must be declared upon a defined domain. The primary unit of data in the relational data model is the data item. Such data items are said to be non-decomposable or atomic. A domain is a set of values of the same type. Domains are therefore pools of values from which actual values appearing in the columns of a table are drawn.

### Point out the pros and cons of using indexes in a database.

Indices speed up searching of values in a certain column or group of columns and are usually implemented as [B-trees](https://en.wikipedia.org/wiki/B-tree).
They can be built-in the table (**clustered**) or stored externally (**non-clustered**). However, the main disadvantage is that adding and deleting records in indexed tables is slower and they should be used for big tables only (e.g. 50 000 rows).

### What's the main purpose of the SQL language?

SQL stands for Structured Query Language. It is used to **communicate** with a database. SQL statements are used to perform CRUD operations. Some typical RDBMS that use SQL are: MySQL, Oracle, Microsoft SQL Server. Although most database systems use SQL, most of them also have their own additional proprietary extensions that are usually only used on their system (e.g T-SQL for SQL Server).

### What are transactions used for?

A good example is a bank system, where security is the primary goal. Consider two clients of a bank, Ivan and Maria. Ivan wants to transfer 100 BGN to Maria. There are two ways to do that:

```c#
ivanBalance -= 100;
mariaBalance += 100;
```

or

```c#
mariaBalance += 100;
ivanBalance -= 100;
```

However, if something goes wrong between the first and the second operation in the pair there is a problem - either 100 BGN have disappeared or they have appeared out of nowhere.

Here comes the idea of transactions. A **transaction** is a mechanism that allows marking a group of operations and execute them in such a way that either they all execute (commit) or the system state will be as if they have not started to execute at all (rollback).

```c#
beginTransaction;
accountB += 100;
accountA -= 100;
commitTransaction;
```

will either transfer 100 BGN or leave both account in the initial state.

### What is a NoSQL database?

A NoSQL ("non SQL" or "not only SQL") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. NoSQL databases are increasingly used in big data and real-time web applications.

They are used because of simplicity of their design, simpler "horizontal" scaling to clusters of machines, which is a problem for relational databases, and finer control over availability. The data structures used by NoSQL databases (e.g. key-value, graph, or document) differ slightly from those used by default in relational databases, making some operations faster in NoSQL and others faster in relational databases. The particular suitability of a given NoSQL database depends on the problem it must solve. Sometimes the data structures used by NoSQL databases are also viewed as "more flexible" than relational database tables.

### Explain the classical non-relational data models.

- **Document model**
   - The central concept of a document model is the notion of a "document". While each document-oriented database implementation differs on the details of this definition, in general, they all assume that documents encapsulate and encode data (or information) in some standard formats or encodings. Encodings in use include XML, YAML, and JSON as well as binary forms like BSON.
   - Documents are addressed in the database via a unique key that represents that document. One of the other defining characteristics of a document-oriented database is that in addition to the key lookup performed by a key-value store, the database offers an API or query language that retrieves documents based on their contents.
   - Compared to relational databases, for example, collections could be considered analogous to tables and documents analogous to records. But they are different: every record in a table has the same sequence of fields, while documents in a collection may have fields that are completely different.
   - Examples: MongoDB, CouchDB, etc.
- **Key-value model**
   - Key-value model use the associative array as their fundamental data model. In this model, data is represented as a collection of key-value pairs, such that each possible key appears at most once in the collection.
   - The Key-value model is one of the simplest non-trivial data models, and richer data models are often implemented on top of it. The key-value model can be extended to an ordered model that maintains keys in lexicographic order. This extension is powerful, in that it can efficiently process key ranges.
   - Key-value model can use consistency models ranging from eventual consistency to serializability. Some support ordering of keys. Some maintain data directly in the RAM, while others employ SSDs or rotating disks.
   - Examples: Oracle NoSQL Database, Redis, etc.
- **Hierarchical key-value model**
   - This data model allows elements to link and be linked by several other elements thus constructing a hierarchical structure. Links usually have additional properties to describe the relation between elements.
- **Wide-column model**
   - Wide-column model takes a hybrid approach mixing the declarative characteristics game of relational databases with the key-value pair based and totally variables schema of key-value stores. Wide Column databases stores data tables as sections of columns of data rather than as rows of data.
   - Examples: Cassandra, HBase, Vertica, etc.
- **Object model**
   - Object-oriented database management systems (OODBMSs) combine database capabilities with object-oriented programming language capabilities. They allow object-oriented programmers to develop the product, store them as objects, and replicate or modify existing objects to make new objects within the OODBMS. Because the database is integrated with the programming language, the programmer can maintain consistency within one environment, in that both the OODBMS and the programming language will use the same model of representation.
   - Some object-oriented databases are designed to work well with object-oriented programming languages such as Delphi, Ruby, Python, Perl, Java, C#, Visual Basic .NET, C++, Objective-C.
   - Examples: Cache, Perst, Shoal, etc.

### Give few examples of NoSQL databases and their pros and cons.

- **MongoDB**
    - Advantages
        - Schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. This is difficult to implement in a performant manner in RDBMS.
        - Ease of scale-out. Scale reads by using replica sets. Scale writes by using sharding (auto balancing).
        - Cost. MongoDB is free and can run on Linux.
        - You can choose what level of consistency you want depending on the value of the data.
    - Disadvantages
        * Data size in MongoDB is typically higher due to e.g. each document has field names stored it.
        * Less flexibility with querying.
        * No support for transactions - certain atomic operations are supported, at a single document level.
        * Less up to date information available/fast evolving product.
- **Redis**
    - Advantages
        * Stores data in a variety of formats: list, array, sets and sorted sets.
        * Multiple commands at once.
        * Blocking reads - it will wait until another process writes data to the cache.
        * Mass insertion of data to prime a cache.
        * Partitions data across multiple Redis instances.
        * Can back data to disk.
    - Disadvantages
        * Super complex to configure - requires consideration of data size to configure well.
        * Lots of server administration for monitoring and partitioning and balancing.
- **Cassandra**
    - Advantages
        - Cassandra is solving the problem of distributed and scalable systems, and it's built to cope with data management challenges of modern business.
        - Cassandra is decentralized system - there is no single point of failure, if minimum required setup for cluster is present - every node in the cluster has the same role, and every node can service any request. Replication strategies can be configured. It is possible to add new nodes to server cluster very easy. Also, if one node fails, data can be retrieved from some of the other nodes (redundancy can be tuned). It is especially suitable for multiple data-center deployment, redundancy, failover and disaster recovery, with possibility of replication across multiple data centers.
    - Disadvantages
        - There is no referential integrity
        - Querying options for retrieving data are very limited.
        - Operations such as ORDER BY, GROUP BY and JOIN do not exist.
