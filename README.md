<h1>List Processing – Teamwork Project Assignment</h1>

<h2><a href="https://trello.com/b/8pgEq3C7/teamwork-assignment-list-processing">Trello link</a></h2>

<h3>Participants</h3>
<ol>
<li><strong>Кирил Георгиев</strong> - <a href="https://github.com/hammer4">GitHub link</a></li>
<li><strong>Тони Димитров</strong> - <a href="https://github.com/tonydimitrov">GitHub link</a></li>
<li><strong>Николай Рогчев</strong> - <a href="https://github.com/nikolayrogchev">GitHub link</a></li>
<li><strong>Bullsized</strong> - <a href="https://github.com/Bullsized">GitHub link</a></li>
</ol>

This document describes the teamwork assignment for the “List Processing” console-based application. The goal of this teamwork exercise is to gain team collaboration skills using tools like GitHub and Trello.

List Processing

Design and implement a console-based application for list processing. It should enter a list of strings from the console and continuously execute commands (like add / remove / replace, invert) over the list.

<p><strong>1. General Requirements</strong></p>
<ul><li>You will be assigned a team of 3-4 students.</li>
<li>Use GitHub as source code repository. The code is shared between all team members.</li>
<li>Use Trello for task management. Create tasks for each piece of work in your team.</li></ul>

<p><strong>2. Commands Description</strong></p>
The first input line holds the initial list of strings:
<ul><li>space separated list of items</li></ul>
Print the list immediately after you read it (space separated).
The next lines hold one of the following commands (until the commands “end” is found):
<ul><li>append <string> – adds the specified string at the end of the list and prints the list (space separated).</li>
<li>prepend <string> – inserts the specified string at the start of the list and prints the list.</li>
<li>reverse – reorders the list items in reversed order (from its end to its start) and prints the list.</li>
<li>insert <index> <string> – inserts the specified string at the specified position in the list and prints the list after that.</li>
<ul><li>Positions are indexed from 0 to list_size - 1.</li>
<li>In case of invalid index, print “Error: invalid index <index>”.</li></ul>
<ul><li>delete <index> – deletes the string at the specified position in the list and prints the list.</li>
<ul><li>Positions are indexed from 0 to list_size - 1.</li>
<li>In case of invalid index, print “Error: invalid index <index>”.</li></ul>
<li>roll left – rolls the list on the left and prints the list. The first list item comes last.</li>
<li>roll right – rolls the list on the right and prints the list. The last list item comes first.</li>
<li>sort – sorts the list in alphabetical order and prints the list.</li>
<li>count <string> – prints how many times the specified string occurs in the list (case sensitive). The command prints a single integer number as output.</li>
<li>end – stops the execution of commands. Print “Finished” as command output.</li></ul>
Each command produces one of the following outputs:
<ul><li>In case of success the command prints its expected output as described above.</li>
<li>In case of error (e.g. invalid index or command parameter) the commands prints “Error: <error message>”.</li>
<ul><li>In case of invalid command name print “Error: invalid command”. Command names are case-sensitive.</li>
<li>In case of invalid number of parameters or incorrect format of the parameters print “Error: invalid command parameters”.</li></ul></ul></ul>

<p><strong>3. Examples</strong></p>

<p><strong>4. Tasks in Trello</strong></p>
Split the work into tasks in a Trello project board:
<ul><li>Create 4 lists: Backlog | In Progress | For Review | Done.</li>
<ul><li>All tasks initially start from the “Backlog” list. Assign project members for the first few tasks.</li>
<li>When the work on certain task starts, move it to “In Progress”. The task stays in this list during the time of working on it.</li>
<li>After a task is completed, put your changes in GitHub (with merge if required) and move the task to “For Review”. The task is still not done, because it requires someone to review it.</li>
<li>Assign team member to review each completed task. This is an important part of the process. The concept of reviewing for this project is as follows:</li></ul>
<ul><li>A team member implements some functionality and moves its task to “For Review”.</li>
<li>Other team member verifies that the functionality is correctly implemented and moves it to “Done” or fixes the bugs / problems and then assigns another team member to review it.</li></ul>
<ul><li>All tasks should flow during all the states: Backlog > In Progress > For Review > Done.</li></ul>
<li>Initially split the project into tasks and create the tasks in Trello. Typical tasks to consider:</li>
<ul><li>Create the GitHub project and invite all team members.</li>
<li>Design the project structure (files, classes, interfaces, command parsing logic, others).</li></ul>
<ul><li>The project structure should allow adding new commands easily.</li>
<li>The project structure should allow several team members to work in parallel on the shared source code. Think about how to merge conflicting changes!</li>
<li>Design and implement the command parsing and processing infrastructure.</li></ul>
<ul><li>Implement the processing of the first command line (entering the input list)
<li>Implement the “append” command.</li>
<li>Implement the “prepend” command.</li>
<li>Implement the “reverse” command.</li>
<li>Implement the “insert” command.</li>
<li>Implement the “delete” command.</li>
<li>Implement the “roll left” command.</li>
<li>Implement the “roll right” command.</li>
<li>Implement the “sort” command.</li>
<li>Implement the “count” command.</li>
<li>Implement the “end” command.</li></ul>
<li>Process all Trello tasks for the project until the project is finished.</li>
<ul><li>Assign project members (one or several) for each task.</li>
<li>Use the task flow: Backlog > In Progress > For Review > Done.</li></ul></li></ul>

<p><strong>5. Submitting Your Work</strong></p>
You should submit until 21-Nov-2017 a link to your GitHub repository at the course site under the topic “Task Management Tools”
<ul><li>In the README.md file put a link to your Trello project.</li>
<li>Make sure your Trello project is public (for view only).</li></ul>
Each team member submits the same link!
