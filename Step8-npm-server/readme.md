#IronManRobot

## Overview
1. Carefully read the requests 
    1. I know you are a genius and can understand everything on first read, but even Hercules had to do 12 works. Are you Hercules?
1. Copy/paste files from **request** to **student-work**
1. Change files in **student-work** until requests are met
    1. Practicly behave like a politician. Take my work, refine it a bit, then take credit of the ideea like it's your own

## Step 8-npm-server
1. We will setup our first server
    1. Install **dotnet core** sdk
        1. Link: https://dotnet.microsoft.com/download
        1. Choose **Download .NET Core SDK**
    1. Right-click **Step8-npm-server/student-work/webserver** -> "Open in terminal"
        1. Type **dotnet run**
            1. Check no error appeared in terminal. Otherwise, contact Spiderman !!!!!
            1. Open https://localhost:5001 in chrome borser
            1. You see the error **Your connection is not private**
            1. We will not go into details here (short story: https is a secure connection witch requires a valid certicate to run. Our local server only provides a local and temporary certificate witch the chrome browser does not recognize)
            1. Click **Advanced** -> **Proceed to localhost (unsafe)**