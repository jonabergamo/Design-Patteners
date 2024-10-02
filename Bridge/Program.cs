IDrawImplementation computerScreen = new ComputerScreen();
IDrawImplementation printerScreen = new PrinterScreen();

Shape circleOnComputer = new Circle(10, 15, 20, computerScreen);
Shape rectangleOnPrinter = new Rectangle(30, 40, printerScreen);

circleOnComputer.Draw(20, 15);
rectangleOnPrinter.Draw(10, 30);
