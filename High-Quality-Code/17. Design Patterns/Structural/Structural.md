# Structural patterns

Дефинират начини за асемблирането и композицията на различните класове, като един вид структурират "комуникацията" между тях, основната цел на което е добавянето на нова функционалност да не изисква промени в огромно количество файлове.

## Composite

#### Описание

Композиране на обекти в дървовидни структури с цел представянето на някакъв тип йерархия. Всеки обект, независимо къде се намира в йерархията, се използва по един и същ начин.

#### Диаграма

<img src="http://www.dofactory.com/images/diagrams/net/composite.gif" alt="Composite pattern" />

#### Учасници

- `Component`
    - дефинира интерфейс за компонентите, участващи в композицията
    - имплементира някакво поведение по подразбиране
    - дефинира интерфейс за достъпване на децата на компонент
    - може да дефинира интерфейс за достъп до родител на компонент или да го имплементира директно
- `Leaf`
    - представлява компонент без деца
- `Composite`
    - дефинира поведение за компоненти, които имат деца
    - пази в себе си деца от тип `Component`
    - имплементира декларираните методи в `Component` класа
- `Client`
    - използва обектите в композицията през `Component` интерфейса

#### Имплементация

```c#
namespace DesignPatterns.Structural.Composite
{
    using System;
    using System.Collections.Generic;

    public class CompositeExample
    {
        public static void Main()
        {
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Recursively display tree
            root.Display(1);
        }
    }

    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
        : base(name)
        {
        }

        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in this.children)
            {
                component.Display(depth + 2);
            }
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name)
        : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf.");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
```

## Decorator

#### Описание

Динамично добавяне на допълнителна отговорност на обект. Декораторите дават гъвкава алтернатива на наследяването с цел добавяне на допълнителна функционалност. Най-често се използва за решаването на *class explosion*.

#### Диаграма

<img src="http://www.dofactory.com/images/diagrams/net/decorator.gif" alt="Decorator" />

#### Учасници

- `Component` (`LibraryItem`)
    - дефинира интерфейс за обекти, на които може да им се добавя отговорност динамично
- `ConcreteComponent` (`Book`, `Video`)
    - дефинира конкретния обект, за който можем да закачим допълнителна отговорност
- `Decorator` (`Decorator`)
    - съдържа референция към `Component` обект и дефинира интерфейс, който имплементира `Component` интерфейса
- `ConcreteDecorator` (`Borrowable`)
    - добавя отговорности на обект

#### Имплементация (реален пример)

```c#
namespace DesignPatterns.Structural.Decorator
{
    using System;
    using System.Collections.Generic;

    public class DecoratorExample
    {
        public static void Main()
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            Borrowable borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");

            borrowableVideo.Display();
        }
    }

    public abstract class LibraryItem
    {
        public int NumberOfCopies { get; set; }

        public abstract void Display();
    }

    public class Book : LibraryItem
    {
        private string author;
        private string title;

        public Book(string author, string title, int numberOfCopies)
        {
            this.author = author;
            this.title = title;
            this.NumberOfCopies = numberOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", this.author);
            Console.WriteLine(" Title: {0}", this.title);
            Console.WriteLine(" # Copies: {0}", this.NumberOfCopies);
        }
    }

    public class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;

        public Video(string director, string title, int numberOfCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumberOfCopies = numberOfCopies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", this.director);
            Console.WriteLine(" Title: {0}", this.title);
            Console.WriteLine(" # Copies: {0}", this.NumberOfCopies);
            Console.WriteLine(" Playtime: {0}\n", this.playTime);
        }
    }

    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }

    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem)
        : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in this.borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
```

## Bridge

#### Описание

Тотално разделя абстракцията от имплементацията с цел по-лесна подмяна и добавяне на функционалност. Често помага за решаването на *class explosion*.

#### Диаграма

<img src="http://www.dofactory.com/images/diagrams/net/bridge.gif" alt="Bridge pattern" />

#### Учасници

- `Abstraction`
    - дефинира интерфейс на някаква абстракция
    - пази референция към обект от тип `Implementor`
- `RefinedAbstraction`
    - имплементира `Abstraction` интерфейса
- `Implementor`
    - дефинира интерфейс за имплементиращите го класове
    - не е задължително да се придържа към интерфейса на `Abstraction`, дори могат да бъдат доста различни
    - най-често `Implementator` дефинира по-примитивни операции, а `Abstraction` дефинира такива на по-високо ниво, базирани на примитивните
- `ConcreteImplementor`
    - имплементира `Implementator` интерфейса

#### Имплементация

```c#
namespace DesignPatters.Structural.Bridge
{
    public class BridgeExample
    {
        public static void Main()
        {
            Abstraction someAbstraction = new RefinedAbstraction();

            // Set one implementor
            someAbstraction.Implementor = new ConcreteImplementorA();
            someAbstraction.Operation();

            // Set another => high flexibility
            someAbstraction.Implementor = new ConcreteImplementorB();
            someAbstraction.Operation();
        }
    }

    // Note that the abstraction is totally decoupled from the implementation (dependency inversion).
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor { set; }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    // The implementation doesn't know that the abstraction exists either.
    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
```
