# 📞 Arduino DTMF / Serial Port Tool

**ArduniodtmfHack** is a Windows desktop application built with C# and Windows Forms for communicating with a serial-connected device through COM ports and displaying incoming serial data in a graphical interface.

Despite the original project name, the current source code primarily implements **serial port connection, baud-rate selection, live serial output, connection control and launching a bundled dialing utility**. fileciteturn199file0

## ✨ Features

- 🔌 Detect available Windows COM ports
- ⚙️ Select COM port and baud rate
- ▶️ Open a serial connection
- ⏹️ Close the serial connection
- 📡 Read incoming serial data continuously
- 📝 Display received data in the application window
- 🧹 Clear the serial output area
- 📞 Launch the bundled `Dial.exe` utility
- 🖥️ Windows Forms GUI with DevComponents DotNetBar controls

## 🛠️ Technologies

- **C#**
- **Windows Forms**
- **.NET Framework**
- **System.IO.Ports / SerialPort**
- **DevComponents DotNetBar**
- **Visual Studio**

The application uses `SerialPort.GetPortNames()` to enumerate available COM ports and reads incoming data with `SerialPort.ReadExisting()`. fileciteturn199file0

## 📂 Project Structure

```text
ArduniodtmfHack/
│
├── ArduniodtmfHack.sln
├── LICENSE
│
└── ArduniodtmfHack/
    ├── ArduniodtmfHack.csproj
    ├── App.config
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Program.cs
    ├── Properties/
    └── bin/
```

## 🔌 Serial Port Workflow

The main workflow is:

```text
Detect COM Ports
      │
      ▼
Select COM + Baud Rate
      │
      ▼
Open SerialPort
      │
      ▼
Read Incoming Data
      │
      ▼
Display in Text Area
```

When the connection is opened, a timer periodically reads data from the serial port and appends it to the output textbox. When the connection is closed, the timer is stopped and the serial port is closed. fileciteturn199file0

## ⚙️ Usage

1. Connect the serial device to the Windows computer.
2. Start the application.
3. Select the appropriate **COM port**.
4. Select the baud rate.
5. Click the connection button.
6. Incoming serial data will appear in the output area.
7. Use the clear button to remove the displayed output.
8. Close the connection when finished.

The exact baud-rate options are defined by the application's form configuration. The source code reads the selected value and assigns it to `SerialPort.BaudRate`. fileciteturn199file0

## 📞 Dial Utility

The project also attempts to launch:

```text
Dial/Dial.exe
```

from the application's startup directory. The current implementation starts this utility with a fixed example argument. fileciteturn199file0

> Make sure the expected `Dial.exe` file and directory are present if this feature is required.

## ⚙️ Installation

### Requirements

- Windows
- Visual Studio
- A compatible .NET Framework runtime
- A serial/COM device for hardware communication
- DevComponents DotNetBar dependency

### Clone

```bash
git clone https://github.com/ebubekirbastama/ArduniodtmfHack.git
cd ArduniodtmfHack
```

Open:

```text
ArduniodtmfHack.sln
```

in Visual Studio and build the solution.

## 🔧 Troubleshooting

### No COM ports are listed

Check that:

- The device is connected.
- The correct USB/serial driver is installed.
- Windows recognizes the device in Device Manager.
- No other application is already using the COM port.

### Connection cannot be opened

Verify the selected COM port and baud rate. Another application may already have exclusive access to the port.

### No data is displayed

Check the device's serial configuration, baud rate and communication parameters. The application currently focuses on reading existing serial data and does not provide a configurable protocol decoder. fileciteturn199file0

## ⚠️ Technical Notes

The current implementation uses a `System.Windows.Forms.Timer` to poll the serial port. For larger or high-throughput serial streams, a more robust asynchronous/event-based architecture can improve responsiveness and reliability.

Recommended future improvements:

- Replace timer polling with `SerialPort.DataReceived` or an async reader.
- Add configurable parity, data bits and stop bits.
- Add selectable encoding.
- Add structured serial logging to files.
- Add timestamped received messages.
- Improve exception and connection-state handling.
- Remove hard-coded paths and arguments.
- Modernize the UI and dependency management.

## 🔐 Responsible Use

Use serial communication and dialing functionality only with devices, systems and communication services you are authorized to operate. Do not use the software to interfere with or access third-party systems without permission.

## 📄 License

This repository contains a `LICENSE` file. Refer to it for the applicable licensing terms.

## 👨‍💻 Developer

**Ebubekir Baştama**

GitHub: https://github.com/ebubekirbastama
