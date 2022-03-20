# How to Implement RabbitMQ in ASP.NET Core Web API?

We are going to use two applications, a Producer application, which is a Web API project, and a Subscriber application, which is a console application.

First, we need to ensure the RabbitMQ package is added to our applications, which can be found on the NuGet Package Manager as **RabbitMQ.Client**. With this package added, we are ready to send and receive messages.

# What is RabbitMQ and How It Works?
RabbitMQ is just one of many message brokers, which handles accepting, storing, and sending messages.

# What Are the Advantages of Message Queues?
Message queues allow us to build decoupled applications while improving the performance, reliability, and scalability of our applications. We don’t want to create tight coupling between our applications, because doing so would mean we couldn’t independently change one application without causing breaking changes in another application.

When we introduce message queues into our application architecture, our Producers and Subscribers don’t have to be aware of each other. As long as we keep the message contract the same we can change Producers and Subscribers independently of each other.

# What is RabbitMQ Used For?
Having a message broker, like RabbitMQ, manage our inter-application communication, allows our system as a whole to scale much easier. For example, we can use messages to inform Subscribers of a long-running task that needs processing.

Using a message queue, we can have multiple Subscribers which would each take one or more messages off the queue and process them, without affecting the performance of our Producer or overall application.

# Why Should We Use RabbitMQ?
So why would we choose RabbitMQ, over something such as Azure Service Bus or Amazon Simple Queue Service? We can apply the same argument of loosely coupled applications to that of our choice of a message broker.

We avoid being tightly coupled to a message broker offering from one of the Cloud Providers as RabbitMQ is an open-source, platform-agnostic solution.

# How Does RabbitMQ Work?
Before we look at the code, there are a couple of concepts we must cover first:

**Producers/Publishers** – these are applications that send data to RabbitMQ
**Queues** – this is where we send messages to in RabbitMQ. Think of it as a large message buffer
**Consumers/Subscribers** – these are applications that receive messages stored in queues
