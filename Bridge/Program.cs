IDrawImplementation computerScreen = new ComputerScreen();
IDrawImplementation printerScreen = new PrinterScreen();

Shape circleOnComputer = new Circle(10, 15, 20, computerScreen);
Shape rectangleOnPrinter = new Rectangle(30, 40, 5, 10, printerScreen);

circleOnComputer.Draw();
rectangleOnPrinter.Draw();
