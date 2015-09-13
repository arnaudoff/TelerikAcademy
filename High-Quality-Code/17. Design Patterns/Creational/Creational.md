# Creational patterns

Отнасят се към създаването на обекти. Грижат се за това да енкапсулират логиката по създаването на класове, абстрахирайки се от това как конкретно инстанциите биват създавани и комбинирани.

## Singleton

#### Описание

Грижи се за това клас да има **само една инстанция** и **тя да е глобално достъпна**. Най-честите примери са:
- `Logger` клас, който запазва някакви събития през работното време на приложението (подобно на Log4Net)
- `Configuration` клас, който се занимава с runtime конфигурацията на приложението

#### Диаграма

<img src="http://www.blackwasp.co.uk/images/Singleton.png" alt="Singleton diagram"/>

#### Недостатъци

- Thread safety - при многонишково програмиране може да се случи така, че при паралелното изпъление на кода от две нишки да се създаде повече от една инстанция
- Coupling - има tight coupling между класа имплементиран чрез Singleton и класовете, които го използват
- Трудно тестваем - подобно на static класовете; поради това някои хора го смятат за anti-pattern.
- Нарушава един от SOLID принципите (Single responsibility) - освен самата логика на класа, в себе си той съдържа и логиката по запазването на една инстанция

#### Имплементация

- Thread unsafe

  ```c#
  public class Singleton
  {
      private static Singleton instance;

      private Singleton() {}

      public static Singleton Instance
      {
          get
          {
              if (instance == null)
              {
                  instance = new Singleton();
              }
              return instance;
          }
      }
  }
  ```

  * Използва се *lazy initialization*: ако все още не сме създали обекта го инстанцираме, ако вече сме го инстанцирали - връщаме съществуващата инстанция.

- Thread safe

  ```c#
  public sealed class Singleton
  {
      private static volatile Singleton instance;
      private static object syncLock = new Object();

      private Singleton() {}

      public static Singleton Instance
      {
          get
          {
              if (instance == null)
              {
                  lock (syncLock)
                  {
                      if (instance == null)
                      {
                          instance = new Singleton();
                      }
                  }
              }

              return instance;
          }
      }
  }
  ```

  * Използва се [double-checked locking](https://en.wikipedia.org/wiki/Double-checked_locking).

## Factory method

#### Описание

Абстрактнo дефинира създаването на обект като *делегира* **конкретния** начин на създаване на обекта на наследниците. Продължение на *Simple factory* шаблона, но с по-голямо ниво на абстракция, което от своя страна позволява повече гъвкавост.

#### Диаграма

<img src="http://www.dofactory.com/images/diagrams/net/factory.gif" alt="Factory" />

В случая `FactoryMethod()` е виртуален метод, който връща `Product` и всеки `ConcreteCreator` override-ва като посочва конкретния начин на създаване на `ConcreteProduct`.

#### Имплементация

```c#

namespace DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodExample
    {
        public static void Main()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
            }
        }
    }

    public abstract class Product
    {
    }

    public class ConcreteProductA : Product
    {
    }

    public class ConcreteProductB : Product
    {
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
```

## Abstract factory

#### Описание

Грижи се за създаването на фамилия от обекти, без да се интересува от конкретните класове.
За разлика от *Factory method*, където наследниците определят конкретния начин на създаване, *Abstract factory* може да се разглежда като обект, съставен от factory methods.
Следователно, при *Abstract factory* се използва т.нар *composition*, докато при *Factory method* се използва просто наследяване. Освен че изпълнява основния принцип на factory шаблоните (а именно да енкапсулира създаването на обекти), *Abstract factory*
вдига нивото на абстракция на проекта като **изцяло разделя клиента от начина, по който се създават обектите**.

#### Диаграма

<img src="http://www.dofactory.com/images/diagrams/net/abstract.gif" alt="Abstract Factory" />

#### Имплементация

```c#
namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryExample
    {
        public static void Main()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }


    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public abstract class AbstractProductA
    {
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }


    public class ProductA1 : AbstractProductA
    {
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
            " interacts with " + a.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {
    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
            " interacts with " + a.GetType().Name);
        }
    }

    public class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            this.abstractProductB = factory.CreateProductB();
            this.abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}
```
