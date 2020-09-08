pipeline {

agent any

stages {

	stage ('Checkout') {
 	 steps{checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'c124e037-9036-4b1c-b5e6-ebe579c2db1c', url: 'https://github.com/mijo2/firstdotnetproject']]]) }
	}
	stage('Restore PACKAGES') {
            steps{sh "dotnet restore"}
        }
        stage('Clean'){
          steps{sh 'dotnet clean'}
        }
        stage('Build'){
          steps{sh 'dotnet build'}
        }
        stage('Test'){
          steps{sh 'cd FirstCoreProject/'
          sh 'dotnet test'}
        }
        stage('Publish'){
          steps{sh 'dotnet publish'}
	}
}
}
