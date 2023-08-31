import tkinter as tk
import subprocess

def woptimizer():
    cleaner = tk.Tk()
    cleaner.title("Windows Optimizer")
    cleaner.geometry("470x120")

    def fullcleanclicked():
        subprocess.call('del /q %SystemRoot%\Prefetch\*.*', shell=True)
        subprocess.call('rd /s /q C:\$Recycle.Bin', shell=True)
        subprocess.call('rmdir /s /q %temp%', shell=True)
        labelfullclean = tk.Label(cleaner, text="Temp, Prefetch and Recycle Bin Cleaned!")
        labelfullclean.place(x=10, y=40)

    buttonfullclean = tk.Button(cleaner, text="Clean Empty Files and Folders", command=fullcleanclicked)
    buttonfullclean.place(x=10, y=10)

    def powercfgclicked():
        subprocess.call('powercfg /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c', shell=True)
        labelpowercfg = tk.Label(cleaner, text="Power Plan is set to High Performance!")
        labelpowercfg.place(x=10, y=93)

    buttonpowercfg = tk.Button(cleaner, text="Set Power Plan to High Performance", command=powercfgclicked)
    buttonpowercfg.place(x=10, y=63)

def windevapps():
    windevapps = tk.Tk()
    windevapps.title("Windows Developer Apps")
    windevapps.geometry("720x120")

    def wdacompilers():
        compilers = tk.Tk()
        compilers.title("Compilers")
        compilers.geometry("699x120")
        compilers.resizable(False, False)

        def buttondnetclicked():
            subprocess.call('start https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer', shell=True)

        buttondnet = tk.Button(compilers, text=".NET Compiler", command=buttondnetclicked)
        buttondnet.place(x=10, y=10)
        labeldnet = tk.Label(compilers, text="- The compiler used to compile the official 3 Microsoft Languages C#, Visual Basic, F#.")
        labeldnet.place(x=97, y=10)

        def buttongccclicked():
            subprocess.call('start https://github.com/brechtsanders/winlibs_mingw/releases/download/13.2.0mcf-16.0.6-11.0.1-ucrt-r2/winlibs-i686-mcf-dwarf-gcc-13.2.0-llvm-16.0.6-mingw-w64ucrt-11.0.1-r2.zip', shell=True)

        buttongcc = tk.Button(compilers, text="GCC(MinGW) Compiler", command=buttongccclicked)
        buttongcc.place(x=10, y=45)
        labelgcc = tk.Label(compilers, text="- This Compiler allows you to run 4 languages ​​languages ​​are C, C++, Fortran, Go, Ada")
        labelgcc.place(x=147, y=45)

        def buttonrustcclicked():
            subprocess.call('start https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer', shell=True)

        buttonatom = tk.Button(compilers, text="Rust Compiler", command=buttonrustcclicked)
        buttonatom.place(x=10, y=80)
        labelatom = tk.Label(compilers, text="- It is the official compiler of the Rust programming language. Known for a powerful debugging system.")
        labelatom.place(x=100, y=80)

    def wdateditors():
        teditors = tk.Tk()
        teditors.title("Text Editor's")
        teditors.geometry("670x295")
        teditors.resizable(False, False)

        def buttonatomclicked():
            subprocess.call('start https://github.com/atom/atom/releases/download/v1.60.0/atom-x64-windows.zip', shell=True)

        buttonatom = tk.Button(teditors, text="Atom Text Editor", command=buttonatomclicked)
        buttonatom.place(x=10, y=10)
        labelatom = tk.Label(teditors, text="- A hackable text editor for the 21st Century.")
        labelatom.place(x=113, y=10)

        def buttonbracketsclicked():
            subprocess.call('start https://github.com/brackets-cont/brackets/releases/download/v2.2.1/Brackets-2.2.1.exe', shell=True)

        buttonbrackets = tk.Button(teditors, text="Brackets Text Editor", command=buttonbracketsclicked)
        buttonbrackets.place(x=10, y=45)
        labelbrackets = tk.Label(teditors, text="- A modern, open source text editor that understands web design.")
        labelbrackets.place(x=127, y=45)

        def buttongvimclicked():
            subprocess.call('start https://github.com/vim/vim-win32-installer/releases/download/v9.0.1811/gvim_9.0.1811_x64.zip', shell=True)

        buttongvim = tk.Button(teditors, text="GVim Text Editor", command=buttongvimclicked)
        buttongvim.place(x=10, y=80)
        labelgvim = tk.Label(teditors, text="- (G)Vim is a highly configurable text editor built to enable efficient text editing.")
        labelgvim.place(x=111, y=80)

        def buttonltableclicked():
            subprocess.call('start https://github.com/LightTable/LightTable/releases/download/0.8.1/lighttable-0.8.1-windows.zip', shell=True)

        buttonltable = tk.Button(teditors, text="Light Table Text Editor", command=buttonltableclicked)
        buttonltable.place(x=10, y=115)
        labelltable = tk.Label(teditors, text="- A customizable editor with instant feedback and showing data values flow through your code.")
        labelltable.place(x=143, y=115)

        def buttonneovimclicked():
            subprocess.call('start https://github.com/neovim/neovim/releases/download/stable/nvim-win64.zip', shell=True)

        buttonatom = tk.Button(teditors, text="NeoVim Text Editor", command=buttonatomclicked)
        buttonatom.place(x=10, y=150)
        labelatom = tk.Label(teditors, text="- literally the future of vim")
        labelatom.place(x=125, y=150)

        def buttonnppclicked():
            subprocess.call('start https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.6/npp.8.5.6.Installer.x64.exe', shell=True)

        buttonnpp = tk.Button(teditors, text="Notepad++ Text Editor", command=buttonnppclicked)
        buttonnpp.place(x=10, y=185)
        labelnpp = tk.Label(teditors, text="- A source code editor which supports several programming languages.")
        labelnpp.place(x=145, y=185)

        def buttonn2clicked():
            subprocess.call('start https://www.flos-freeware.ch/zip/notepad2_4.2.25_x64.zip', shell=True)

        buttonn2 = tk.Button(teditors, text="Notepad2 Text Editor", command=buttonn2clicked)
        buttonn2.place(x=10, y=220)
        labeln2 = tk.Label(teditors, text="- Tiny and fast Notepad replacement with many useful features. ")
        labeln2.place(x=136, y=220)

        def buttonsblmtextclicked():
            subprocess.call('start http://www.sublimetext.com/download_thanks?target=win-x64', shell=True)

        buttonsblmtext = tk.Button(teditors, text="Sublime Text Text Editor", command=buttonsblmtextclicked)
        buttonsblmtext.place(x=10, y=255)
        labelsblmtext = tk.Label(teditors, text="- The sophisticated text editor.")
        labelsblmtext.place(x=149, y=255)

    def wdaides():
        ides = tk.Tk()
        ides.title("IDE's")
        ides.geometry("670x435")
        ides.resizable(False, False)

        def buttonvs22clicked():
            subprocess.call('start https://visualstudio.microsoft.com/tr/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false', shell=True)

        buttonvs22 = tk.Button(ides, text="Visual Studio 2022 IDE", command=buttonvs22clicked)
        buttonvs22.place(x=10, y=10)
        labelvs22 = tk.Label(ides, text="- Microsofts official IDE. Supports a multitude of languages via plugins.")
        labelvs22.place(x=143, y=10)

        def buttonvscodeclicked():
            subprocess.call('start https://code.visualstudio.com/docs/?dv=win', shell=True)

        buttonvscode = tk.Button(ides, text="Visual Studio Code IDE", command=buttonvscodeclicked)
        buttonvscode.place(x=10, y=45)
        labelvscode = tk.Label(ides, text="- Build and debug modern web and cloud applications.")
        labelvscode.place(x=143, y=45)

        def buttonwebstormclicked():
            subprocess.call('start https://www.jetbrains.com/webstorm/download/download-thanks.html', shell=True)

        buttonwebstorm = tk.Button(ides, text="WebStorm IDE", command=buttonwebstormclicked)
        buttonwebstorm.place(x=10, y=80)
        labelwebstorm= tk.Label(ides, text="- A smart JavaScript IDE that uses the full power of the modern JavaScript ecosystem.")
        labelwebstorm.place(x=100, y=80)

        def buttonrubymineclicked():
            subprocess.call('start https://www.jetbrains.com/ruby/download/download-thanks.html?platform=windows', shell=True)

        buttonrubymine = tk.Button(ides, text="RubyMine IDE", command=buttonrubymineclicked)
        buttonrubymine.place(x=10, y=115)
        labelrubymine= tk.Label(ides, text="- An intelligent Ruby IDE that supports many modern frameworks.")
        labelrubymine.place(x=99, y=115)

        def buttonriderclicked():
            subprocess.call('start https://www.jetbrains.com/rider/download/download-thanks.html?platform=windows', shell=True)

        buttonrider = tk.Button(ides, text="Rider IDE", command=buttonriderclicked)
        buttonrider.place(x=10, y=150)
        labelrider= tk.Label(ides, text="- A cross-platform .NET/Mono IDE.")
        labelrider.place(x=73, y=150)

        def buttonpycharmclicked():
            subprocess.call('start https://www.jetbrains.com/pycharm/download/download-thanks.html?platform=windows', shell=True)

        buttonpycharm = tk.Button(ides, text="PyCharm IDE", command=buttonpycharmclicked)
        buttonpycharm.place(x=10, y=185)
        labelpycharm= tk.Label(ides, text="- Python IDE for professional developers with free community edition.")
        labelpycharm.place(x=93, y=185)

        def buttonphpstormclicked():
            subprocess.call('start https://www.jetbrains.com/phpstorm/download/download-thanks.html', shell=True)

        buttonphpstorm = tk.Button(ides, text="PhpStorm IDE", command=buttonphpstormclicked)
        buttonphpstorm.place(x=10, y=220)
        labelphpstorm= tk.Label(ides, text="- Lightning-smart PHP IDE with major frameworks support.")
        labelphpstorm.place(x=95, y=220)

        def buttonnetbeansclicked():
            subprocess.call('start https://dlcdn.apache.org/netbeans/netbeans-installers/18/Apache-NetBeans-18-bin-windows-x64.exe', shell=True)

        buttonnetbeans = tk.Button(ides, text="NetBeans IDE", command=buttonnetbeansclicked)
        buttonnetbeans.place(x=10, y=255)
        labelnetbeans= tk.Label(ides, text="- A free and open-source IDE.")
        labelnetbeans.place(x=93, y=255)

        def buttonintellijideaclicked():
            subprocess.call('start https://www.jetbrains.com/idea/download/download-thanks.html?platform=windows', shell=True)

        buttonintellijidea = tk.Button(ides, text="Intellij IDEA IDE", command=buttonintellijideaclicked)
        buttonintellijidea.place(x=10, y=290)
        labelintellijidea= tk.Label(ides, text="- A modern Java IDE with free community edition.")
        labelintellijidea.place(x=105, y=290)

        def buttoneclipseclicked():
            subprocess.call('start https://www.eclipse.org/downloads/download.php?file=/oomph/epp/2023-06/R/eclipse-inst-jre-win64.exe&mirror_id=1190', shell=True)

        buttoneclipse = tk.Button(ides, text="Eclipse IDE", command=buttoneclipseclicked)
        buttoneclipse.place(x=10, y=325)
        labeleclipse= tk.Label(ides, text="- A powerful IDE.")
        labeleclipse.place(x=82, y=325)

        def buttonclionclicked():
            subprocess.call('start https://www.jetbrains.com/clion/download/download-thanks.html', shell=True)

        buttonclion = tk.Button(ides, text="CLion IDE", command=buttonclionclicked)
        buttonclion.place(x=10, y=360)
        labelclion= tk.Label(ides, text="- Smart cross-platform IDE for C/C++ that uses CMake as a build system.")
        labelclion.place(x=77, y=360)

        def buttonandroidsclicked():
            subprocess.call('start https://redirector.gvt1.com/edgedl/android/studio/install/2022.3.1.19/android-studio-2022.3.1.19-windows.exe', shell=True)

        buttonandroids = tk.Button(ides, text="Android Studio IDE", command=buttonandroidsclicked)
        buttonandroids.place(x=10, y=395)
        labelandroids= tk.Label(ides, text="- The official IDE for Android based on the IntelliJ platform.")
        labelandroids.place(x=122, y=395)

    button = tk.Button(windevapps, text="IDE's", command=wdaides)
    button.place(x=10, y=10)
    labelwdaides = tk.Label(windevapps, text="- IDE (which stands for integrated development environment) is a development environment.")
    labelwdaides.place(x=47, y=10)

    button2 = tk.Button(windevapps, text="Text Editor's", command=wdateditors)
    button2.place(x=10, y=45)
    labelwdateditors = tk.Label(windevapps, text="- Text Editor are programs that exist to edit simple texts.")
    labelwdateditors.place(x=87, y=45)

    button3 = tk.Button(windevapps, text="Compiler's", command=wdacompilers)
    button3.place(x=10, y=80)
    labelwdac = tk.Label(windevapps, text="- A special program that translates a source code into machine code or another programming language.")
    labelwdac.place(x=83, y=80)

root = tk.Tk()
root.title("Tools For Windows")
root.geometry("470x120")

label = tk.Label(root, text="Hello, Welcome to the program. This program offers some features for Windows.")
label.place(x=10, y=10)

button = tk.Button(root, text="Windows Developer Apps", command=windevapps)
button.place(x=10, y=35)

button2 = tk.Button(root, text="Windows Optimizer", command=woptimizer)
button2.place(x=10, y=70)

root.mainloop()