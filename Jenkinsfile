node {

    stage("checkout") {
        bat 'dir'
        git branch:'main', url:'https://github.com/Frank-Yong/BuildT.git'
    }
    
    dir('BuildTLib') {
        stage("clean") {
            bat 'dotnet clean'
        }
        
        stage("build") {
            bat 'dotnet build'
        }
        
        stage("test") {
            bat 'dotnet test'
        }
        
        stage("publish") {
            bat 'dotnet publish'
        }
        
        stage("distribute") {
            fileOperations([fileCopyOperation(excludes: '', flattenFiles: true, includes: '**/BuildTCli/**/publish/*.*', renameFiles: false, sourceCaptureExpression: '', targetLocation: 'C:\\WinApp\\BuildT', targetNameExpression: '')])
        }
        
        stage("archive") {
            archiveArtifacts artifacts: '**/publish/*.*', followSymlinks: false
        }
    }
}


