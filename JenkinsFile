// Powered by Infostretch 

timestamps {

node () {

	stage ('firstnetjob1 - Checkout') {
 	 checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'c124e037-9036-4b1c-b5e6-ebe579c2db1c', url: 'https://github.com/mijo2/firstdotnetproject']]]) 
	}
	stage ('firstnetjob1 - Build') {
 			// Shell build step
sh """ 
dotnet build
cd FirstCoreProject/
dotnet test
dotnet publish 
 """ 
	}
}
}
