echo "hello world!"

node {
    stage("checkout")
    {
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
        
//        parallel testA: {
//            echo "test set A"
//            sleep 2
//            sleep 4
//        }, testB: {
//            echo "test set B"
//            sleep 4
//        }, failFast: true
        
        stage("test") {
            bat 'dotnet test'
        }
        
        stage("publish") {
            bat 'dotnet publish'
        }
        
        stage("distribute") {
            // bat("xcopy C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\pipe\\BuildTLib\\BuildTCli\\bin\\Release\\net8.0\\publish C:\\WinApp\\BuildT /O /X /E /H /K")
            fileOperations([fileCopyOperation(excludes: '', flattenFiles: true, includes: '**/BuildTCli/**/publish/*.*', renameFiles: false, sourceCaptureExpression: '', targetLocation: 'C:\\WinApp\\BuildT', targetNameExpression: '')])
        }
        
        stage("archive") {
            archiveArtifacts artifacts: '**/publish/*.*', followSymlinks: false
        }
    }
}


