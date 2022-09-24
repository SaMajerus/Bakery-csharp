# "Pierre's Bakery"

#### By Sam Majerus

#### User enters how many of each item they want at this hypothetical Bakery, and they get a receipt printed out for them in return.  

## Technologies Used

* C# (C-sharp)
* .NET 5 
* Markdown
* Git Bash (Used in: Local Cmd-line Terminal, navigation of local directories)
* GitHub (Remote repositories)
* GitHub template repository (OpenWeatherAPI project)


## Description
[TO BE REVIEWED/UPDATED -- PLEASE IGNORE THIS SECTION!!]

<!--
User enters an amount in USD, then selects which currency they would like to convert that USD amount into. 
Once submitted, the program uses the Fetch API to send a call to the ExchangeRate API (linked below), in order to perform the currency conversion (using real-time, updated conversion rates).  Once the response is recieved, one of two things will happen:  1) The user will have their converted currency amount displayed to them,  or 2) an error is output.   The latter case only occurs if the API returns an error code. 
-->

## Setup/Installation Requirements
[TO BE REVIEWED/UPDATED -- PLEASE IGNORE THIS SECTION!!]

<!--
* All that's required to run this application -- at minimum -- is: a decently-performing laptop, and a reliable Internet connection.

* To Clone the program from the GitHub repo to your local machine:

  * 1.) Click the green button labelled 'Code'. Under the 'HTTPS' tab, there are 3 Options. This program will only work at the moment if you choose Option 1, so move on to Step 2.

  * 2.) Copy the link. Then, in Git BASH, navigate to the folder you want to put the files in. This can be your Desktop directory, or a different subfolder, whatever you prefer. Next, still in the Git BASH console, type the following (with the copied-link in place of 'HTTPS') and hit ENTER: 'git clone HTTPS' Several lines of text will come up in the console -- that's the files being copied into whichever directory/folder you're in currently. Then, do the following once your prompt line reappears: While still in the console window, type 'pwd' and press ENTER. This will display your current file path. Copy that by highlighting it and pressing 'Ctrl-C', and then pasting it in an easily-accessible word processor like Notepad for reference. Next, open File Explorer, and navigate to through your files according to that File Path you just copy-pasted for reference. Once you've done this, move on to Step 3.

  * 3.) Before opening the HTML file, do the following: right-click the containing folder (in which the newly-copied files are stored) and select the option that says 'Pin to Quick Access'. This is to ensure that you can find this folder again in the steps that follow. Move on to Step 4.

  * 4.) Open VS Code. Then, click on the page icon at the top of the left-hand toolbar. Then click 'Open Folder'. When the Windows File Explorer window appears, navigate to and select the containing folder you pinned in the previous step. Once you've selected the folder and clicked the button to open the folder in VS Code, move on to Step 5.

  * 5.) Open a New Terminal (shortcut is Ctrl+Shift+`). Then, in the command line, type 'npm install'. Everything needed to run the program with 'npm' will install -- your command prompt will show up again once the operation is complete; DO NOT Kill the terminal or close VS Code. Once this is complete, move onto the next Section. <br>

* Creating and Storing your API Key
  In order for the program to work properly, you need to create and store your free API Key.  To generate the key, we create an account on the ExchangeRate API website. 
    * To go to the sign-up page on the website, [click here](https://app.exchangerate-api.com/sign-up). 
    * When you're ready to create the account, click on the blue button that says  "Accept Terms & Create API Key!". 
    * Switch back into VS Code.  If your command line shows that you're not currently in the root folder, navigate there.  Then, type the following:   'code .env' 
    This creates and opens a hidden file called '.env'.  All we need to do here is type the following:  'API_KEY=[your api key]'.
    
    * Now switch back to the browser. At the top of the Dashboard page that the blue button brought you to, highlight the text immediately after the large-lettered text that says 'Your API Key:'.   Copy it (Ctrl-C), switch back to the '.env' file in VS Code, and paste (Ctrl-V) your API Key into the space occupied by the text '[your api key]'.    Save the file (Ctrl-S) and close it.   (The program will use that API key in its calls to the ExchangeRate API.) 
  Continue to the next section. <br>

* Running the Program
  * In your GIT BASH command line, type 'npm run start'. This will compile and bundle the JavaScript files, and open the development server. A new tab will open in your browser with the HTML page. 
  The program is now up and running! 
-->


## Known Bugs
* May not work properly if negative numbers, non-numbers (like Strings), etc. are input when prompted.  (No error checking implemented at the moment)


## License

Email me at ladolego@gmail.com for questions, ideas, concerns, or even any issues that you run into. You may also clone or Fork the content in this Repo to fiddle around with it, if you like.

Licensed through MIT. Copyright (c) 9/23/2022, Samuel Majerus.