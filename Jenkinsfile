pipeline {
  agent any
  stages {
    stage('Git pull') {
      steps {
        git(url: 'https://github.com/christercarlsson/jenkins-test.git', branch: 'master')
      }
    }
  }
}