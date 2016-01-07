# GeekQuiz
Build a Single Page Application (SPA) with ASP.NET Web API and Angular.js

# How to use it
Run it with Visual Studio. The user must create an account and log in to play.


#Database
Entity Framework will create a database if one doesn't already exist. 

It will be seeded with default geek questions (mostly programming / internet lore)

Questions are stored in dbo.TriviaQuestions

Answers are stored in dbo.TriviaOptions

Logging is stored in dbo.TriviaAnswers


#AngularJs Code
The app is contained in a module called 'QuizApp' with a controller called 'QuizCtrl' inside of it.

$scope and $http are required to work.

## Methods
.answer() (returns 'correct' or 'incorrect' based on bool value of $scope.correctAnswer.

.nextQuestion() (retrieves the next question from the web service and uses the return to fill the answer options array)

.sendAnswer() passes the answer to the web service.

## Fields
.answered (bool)

.title (string)

.options (collection of possible answers)

.correctAnswer (bool)

.working (bool)

#The Single Page
The page used to play the game is index.cshtml

It has a  script reference to Scripts/angular.js and Scripts/app/quiz-controller.js

It has two primary containers on the page, a place for the question and a place for possible answers

The question and the indicator if it was answered correctly is exposed by {{answer()}}

The potential answers (options) are exposed as buttons with ng-repeat="option in options" and written as {{option.title}}

Button click events are handled with .sendAnswer(option)
