# Web Full Stack test / AdBrain - Victor Arbues

This repository contains my solution for the web full stack AdBrain hiring test.
In order to make it work, an instance of sql express got to be installed on the target machine with an empty database called 'WebFullStackDb' created on it, with login adBrainUser 8Fr6`~m\Xk_w8/?

The solution uses Entity Framework code first through db migrations. In order to make them work, just run this command on the Package Manager Console while selecting the DataAccess.EF.Migrations project:
```sh
$ Update-Database
```
If everything goes fine, the environment will be ready to be run: start the Api project and just hit http://yoururl/sports?domain=youtube.com

