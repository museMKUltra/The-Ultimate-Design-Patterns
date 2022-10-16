using System;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Exercise;
using DesignPatterns.Bridge;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Exercise;
using DesignPatterns.Command;
using DesignPatterns.Command.Editor;
using DesignPatterns.Command.Exercise;
using DesignPatterns.Composite;
using DesignPatterns.Composite.Exercise;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Facade.Exercise;
using DesignPatterns.flyweight;
using DesignPatterns.flyweight.Exercise;
using DesignPatterns.Iterator;
using DesignPatterns.Iterator.Exercise;
using DesignPatterns.Mediator;
using DesignPatterns.Mediator.Exercise;
using DesignPatterns.Memento;
using DesignPatterns.Memento.Exercise;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Exercise;
using DesignPatterns.Proxy;
using DesignPatterns.State;
using DesignPatterns.State.Abuse;
using DesignPatterns.State.Exercise;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Exercise;
using DesignPatterns.Template;
using DesignPatterns.Template.Exercise;
using DesignPatterns.Visitor;
using DesignPatterns.Visitor.Exercise;
using Button = DesignPatterns.Command.fx.Button;
using HtmlDocument = DesignPatterns.Command.Editor.HtmlDocument;
using SpreadSheet = DesignPatterns.Observer.SpreadSheet;
using UndoCommand = DesignPatterns.Command.Editor.UndoCommand;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Mosh");
            Console.WriteLine(user.Name);

            var taxCalculator = GetCalculator();
            taxCalculator.CalculateTax();

            var account = new Account();

            account.SetBalance(3);
            account.Deposit(2);
            account.Withdraw(1);

            Console.WriteLine(account.GetBalance());

            var mailService = new MailService();
            mailService.SendEmail();

            var textBox = new TextBox();
            textBox.Enable();

            DrawUIControl(new TextBox());
            DrawUIControl(new CheckBox());

            var editor = new Editor();
            var history = new History();

            editor.Content = "a";

            history.Push(editor.CreateState());
            editor.Content = "b";

            history.Push(editor.CreateState());
            editor.Content = "c";

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            var document = new Document();
            var documentHistory = new DocumentHistory();

            document.Content = "content";
            document.FontName = "name";
            document.FontSize = 12;
            document.Console();

            documentHistory.Push(document.CreateState());
            document.FontName = "font-name";
            document.FontSize = 14;
            document.Console();

            document.Restore(documentHistory.Pop());
            document.Console();

            var canvas = new Canvas();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();

            canvas.CurrentTool = new SelectionTool();
            canvas.MouseUp();

            canvas.CurrentTool = new EraserTool();
            canvas.MouseUp();
            canvas.MouseDown();

            var stopwatch = new Stopwatch(new StoppedState());
            stopwatch.Click();
            stopwatch.Click();
            stopwatch.Click();

            var directionService = new DirectionService();
            directionService.Mode = TravelMode.Bicycling;
            Console.WriteLine(directionService.GetEta());
            directionService.Mode = TravelMode.Transit;
            Console.WriteLine(directionService.GetDirection());

            var direction = new Direction();
            direction.CurrentTravel = new Bicycling();
            Console.WriteLine(direction.GetEta());
            direction.CurrentTravel = new Transit();
            Console.WriteLine(direction.GetDirection());

            var browseHistory = new BrowseHistory();
            browseHistory.Push("a");
            browseHistory.Push("b");
            browseHistory.Push("c");

            foreach (var url in browseHistory.Urls)
            {
                Console.WriteLine(url);
            }

            var iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            var browseFixedHistory = new BrowseFixedHistory();
            browseFixedHistory.Push("a");
            browseFixedHistory.Push("b");
            browseFixedHistory.Push("c");

            var fixedIterator = browseFixedHistory.CreateIterator();
            while (fixedIterator.HasNext())
            {
                Console.WriteLine(fixedIterator.Current());
                fixedIterator.Next();
            }

            var productCollection = new ProductCollection();
            productCollection.Add(new Product(0, "a"));
            productCollection.Add(new Product(1, "b"));
            productCollection.Add(new Product(2, "c"));
            var productIterator = productCollection.CreateIterator();
            while (productIterator.HasNext())
            {
                Console.WriteLine(productIterator.Current());
                productIterator.Next();
            }

            ImageStorage2.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            ImageStorage2.Store("b", new PngCompressor(), new HighContrastFilter());

            var desChatClient = new ChatClient(new DesEncryption());
            desChatClient.Send("a");
            var aesChatClient = new ChatClient(new AesEncryption());
            aesChatClient.Send("b");

            var generateReportTask = new GenerateReportTaskExecutor(new AuditTrail());
            var transferMoneyTask = new TransferMoneyTaskExecutor(new AuditTrail());
            generateReportTask.Execute();
            transferMoneyTask.Execute();

            var toast = new Toast();
            var dialog = new Dialog();
            toast.Close();
            dialog.Close();

            var customerService = new CustomerService();
            var addCustomerCommand = new AddCustomerCommand(customerService);
            var button = new Button(addCustomerCommand);
            button.Click();

            var compositeCommand = new CompositeCommand();
            compositeCommand.AddCommand(new BlackAndWhiteCommand());
            compositeCommand.AddCommand(new ResizeCommand());
            compositeCommand.Execute();
            compositeCommand.Execute();

            Editor();

            Observer();

            Mediator();

            ChainOfResponsibility();

            Visitor();

            Composite();

            Adapter();

            Decorator();

            Facade();

            Flyweight();

            Bridge();

            Proxy();
        }

        private static void Proxy()
        {
            var library = new Library();
            string[] fileNames = { "a", "b", "c" };

            foreach (var fileName in fileNames)
                library.Add(new EbookProxy(fileName));

            library.OpenEbook("a");
            library.OpenEbook("b");
        }

        private static void Bridge()
        {
            var remoteControl = new RemoteControl(new SonyTV());
            remoteControl.TurnOn();
            var advancedRemoteControl = new AdvancedRemoteControl(new SamsungTV());
            advancedRemoteControl.SetChannel(1);
        }

        private static void Flyweight()
        {
            var pointService = new PointService(new PointIconFactory());
            foreach (var point in pointService.GetPoints())
            {
                point.Draw();
            }

            Demo.Show();
        }

        private static void Facade()
        {
            var notificationService = new NotificationService();
            notificationService.Send("hello world", "target");

            var tweetService = new TweetService();
            tweetService.GetRecentTweets();
        }

        private static void Decorator()
        {
            StoreCreditCard(new CloudStream());
            StoreCreditCard(new EncryptedCloudStream(new CloudStream()));
            StoreCreditCard(new CompressedCloudStream(new CloudStream()));
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));

            var editor = new Decorator.Exercise.Editor();
            editor.OpenProject("...");
        }

        private static void StoreCreditCard(IStream stream)
        {
            stream.Write("here's some data");
        }

        private static void Adapter()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));
            imageView.Apply(new CaramelAdapter());

            var emailClient = new EmailClient();
            emailClient.AddProvider(new GmailProvider(new GmailClient()));
            emailClient.DownloadEmail();
        }

        private static void Composite()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // square
            group1.Add(new Shape()); // square

            var group2 = new Group();
            group2.Add(new Shape()); // circle
            group2.Add(new Shape()); // circle

            var group = new Group();
            group.Add(group1);
            group.Add(group2);

            group.Render();
            group.Move();

            var team1 = new Team();
            team1.Add(new Truck());
            team1.Add(new Human());
            team1.Add(new Human());

            var team2 = new Team();
            team2.Add(new Truck());
            team2.Add(new Human());
            team2.Add(new Human());

            var team = new Team();
            team.Add(team1);
            team.Add(team2);

            team.Operation();
        }

        private static void Visitor()
        {
            var htmlDocument = new Visitor.HtmlDocument();
            htmlDocument.Nodes.Add(new HeadingNode());
            htmlDocument.Nodes.Add(new AnchorNode());
            htmlDocument.Execute(new HighlightOperation());
            htmlDocument.Execute(new PlainTextOperation());

            var waveFile = new WaveFile();
            waveFile.Segments.Add(new FactSegment());
            waveFile.Segments.Add(new FormatSegment());
            waveFile.Segments.Add(new FormatSegment());
            waveFile.Execute(new ReduceNoiseVisitor());
            waveFile.Execute(new AddReverbVisitor());
            waveFile.Execute(new NormalizeVisitor());
        }

        private static void ChainOfResponsibility()
        {
            // authenticator -> logger -> compressor
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var webServer = new WebServer(authenticator);

            webServer.Handle(new HttpRequest { Username = "admin", Password = "1234" });

            var dataFiles = new DataFiles();
            var xlsHandler = new XlsHandler(null);
            var qbwHandler = new QbwHandler(xlsHandler);
            var numbersHandler = new NumbersHandler(qbwHandler);
            var dataReader = new DataReader(numbersHandler);

            dataReader.Read(dataFiles);
        }

        private static void Mediator()
        {
            var articlesDialogBox = new ArticlesDialogBox();
            articlesDialogBox.SimulateUserInteraction();

            var dialogBox = new Mediator.Observer.ArticlesDialogBox();
            dialogBox.SimulateUserInteraction();

            var signUpDialogBox = new SignUpDialogBox();
            signUpDialogBox.SimulateUserInteraction();
        }

        private static void Observer()
        {
            var dataSource = new DataSource();
            var spreadSheet1 = new SpreadSheet(dataSource);
            var spreadSheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(spreadSheet1);
            dataSource.AddObserver(spreadSheet2);
            dataSource.AddObserver(chart);
            dataSource.Value = 1;

            var stockSource = new StockSource();
            var statusBar = new StatusBar(stockSource);
            var statusBar2 = new StatusBar(stockSource);
            var stockListView = new StockListView(stockSource);

            stockSource.AddStock(statusBar);
            stockSource.RemoveStock(statusBar);
            stockSource.AddStock(statusBar2);
            stockSource.AddStock(stockListView);
            stockSource.Value = 2;
        }

        private static void Editor()
        {
            var editorHistory = new Command.Editor.History();
            var document = new HtmlDocument { Content = "Hello World" };
            var boldCommand = new BoldCommand(document, editorHistory);

            boldCommand.Execute();
            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(editorHistory);
            undoCommand.Execute();
            Console.WriteLine(document.Content);

            var history = new Command.Exercise.History();
            var videoEditor = new VideoEditor { Contrast = 2, Text = "two" };
            Console.WriteLine(videoEditor.ToString());

            var videoCommand = new VideoCommand(videoEditor, history);
            videoCommand.Execute();
            videoEditor.Contrast = 1;
            videoEditor.Text = "one";
            Console.WriteLine(videoEditor.ToString());

            var undo = new Command.Exercise.UndoCommand(history);
            undo.Execute();
            Console.WriteLine(videoEditor.ToString());
        }

        private static ITaxCalculator GetCalculator()
        {
            return new TaxCalculator2019();
        }

        public static void DrawUIControl(UIControl control)
        {
            control.Draw();
        }
    }
}