pipeline {

agent any

stages {

	stage ('Checkout') {
 	 checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'c124e037-9036-4b1c-b5e6-ebe579c2db1c', url: 'https://github.com/mijo2/firstdotnetproject']]]) 
	}
	stage('Restore PACKAGES') {
            sh "dotnet restore"
        }
        stage('Clean'){
          sh 'dotnet clean'
        }
        stage('Build'){
          sh 'dotnet build'
        }
        stage('Test'){
          sh 'cd FirstCoreProject/'
          sh 'dotnet test'
        }
        stage('Publish'){
          sh 'dotnet publish'
	}
}
}
