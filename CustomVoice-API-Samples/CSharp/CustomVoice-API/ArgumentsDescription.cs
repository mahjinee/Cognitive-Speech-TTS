﻿using System;
using System.Collections.Generic;

namespace CustomVoice_API
{
    class ArgumentsDescription
    {
        public static void PrintAPIUsage()
        {
            Console.WriteLine("");
            Console.WriteLine("Custom Voice API 3.0.");
            Console.WriteLine("");
            Console.WriteLine("Usage: CustomVoice-API [APIKind] [action] [options]");
            Console.WriteLine("");
            Console.WriteLine("--APIKind:");
            Console.WriteLine("     project");
            Console.WriteLine("     dataset");
            Console.WriteLine("     model");
            Console.WriteLine("     voicetest");
            Console.WriteLine("     endpoint");
            Console.WriteLine("     batchsynthesis");
            Console.WriteLine("");
            Console.WriteLine("For more detailed usage, please enter: CustomVoice-API [APIKind]");
        }

        public static void PrintAPIKindUsage(APIKind apiKind)
        {
            switch (apiKind)
            {
                case APIKind.project:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API project:");
                    Console.WriteLine("");
                    Console.WriteLine("All Dataset, Model, VoiceTest, Endpoint are bound in the project.");
                    Console.WriteLine("We need to specify Locale and Gender when creating Project.");
                    Console.WriteLine("The data bound to each Project must be a unique locale and gender.");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API project [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets the list of projects for the authenticated subscription.");
                    Console.WriteLine(" create");
                    Console.WriteLine("     Creates a new project.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Deletes the project identified by the given ID");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API project [action]");
                    break;
                case APIKind.dataset:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API dataset:");
                    Console.WriteLine("");
                    Console.WriteLine("Specify project upload data to create data object.");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API dataset [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets all voice datasets.");
                    Console.WriteLine(" GetByProjectId");
                    Console.WriteLine("     Get the list of datasets for specified project.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Deletes the voice dataset with the given id.");
                    Console.WriteLine(" UploadDataset");
                    Console.WriteLine("     Uploads data and creates a new voice data object.");
                    Console.WriteLine(" UploadDatasetWithLongAudio");
                    Console.WriteLine("     Upload voice dataset with long audio and scripts.");
                    Console.WriteLine(" UploadDatasetWithAudioOnly");
                    Console.WriteLine("     Upload voice dataset only with audio.");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API dataset [action]");
                    break;
                case APIKind.model:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API model:");
                    Console.WriteLine("");
                    Console.WriteLine("Select data to start training model.");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API model [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets a list of voice model details.");
                    Console.WriteLine(" GetByProjectId");
                    Console.WriteLine("     Gets the list of models for specified project.");
                    Console.WriteLine(" Create");
                    Console.WriteLine("     Creates a new voice model object.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Deletes the voice model with the given id.");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API model [action]");
                    break;
                case APIKind.voicetest:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API voicetest:");
                    Console.WriteLine("");
                    Console.WriteLine("Synthetic testing of successful training models.");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API voicetest [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets details of the specified model's voice test.");
                    Console.WriteLine(" GetByProjectId");
                    Console.WriteLine("     Get the list of voice tests for specified project.");
                    Console.WriteLine(" Create");
                    Console.WriteLine("     Creates a new voice test.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Deletes the specified voice test.");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API voicetest [action]");
                    break;
                case APIKind.endpoint:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API endpoint:");
                    Console.WriteLine("");
                    Console.WriteLine("Deploy the model to the endpoint to invoke synthetic voice data");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API endpoint [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets a list of voice endpoint details.");
                    Console.WriteLine(" GetByProjectId");
                    Console.WriteLine("     Gets the list of endpoints for specified project.");
                    Console.WriteLine(" Create");
                    Console.WriteLine("     Creates a new voice endpoint object.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Delete the specified voice endpoint.");
                    Console.WriteLine(" Call");
                    Console.WriteLine("     Calling the endpoint to synthesize voice data.");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API endpoint [action]");
                    break;
                case APIKind.batchsynthesis:
                    Console.WriteLine("");
                    Console.WriteLine("CustomVoice-API batchsynthesis:");
                    Console.WriteLine("");
                    Console.WriteLine("Select supported model IDs (multiple choices) to batch generate data from scripts.");
                    Console.WriteLine("");
                    Console.WriteLine("Usage: CustomVoice-API batchsynthesis [action] [options]");
                    Console.WriteLine("");
                    Console.WriteLine("--action");
                    Console.WriteLine(" Get");
                    Console.WriteLine("     Gets a list of voice synthesis under the selected subscription.");
                    Console.WriteLine(" GetVoices");
                    Console.WriteLine("     Gets a list of supported voices for offline synthesis.");
                    Console.WriteLine(" Create");
                    Console.WriteLine("     Creates a new synthesis.");
                    Console.WriteLine(" Delete");
                    Console.WriteLine("     Deletes the specified voice synthesis task.");
                    Console.WriteLine("");
                    Console.WriteLine("For more detailed usage, please enter: CustomVoice-API batchsynthesis [action]");
                    break;
                default:
                    break;
            }
        }

        public static void PrintAPIActionUsage(APIKind apiKind, Action action, Dictionary<string, List<string>> parameters)
        {
            switch (apiKind)
            {
                case APIKind.project:
                    PrintProjectActionUsage(action, parameters);
                    break;
                case APIKind.dataset:
                    PrintDatasetActionUsage(action, parameters);
                    break;
                case APIKind.model:
                    PrintModelActionUsage(action, parameters);
                    break;
                case APIKind.voicetest:
                    PrintVoiceTestActionUsage(action, parameters);
                    break;
                case APIKind.endpoint:
                    PrintEndpointActionUsage(action, parameters);
                    break;
                case APIKind.batchsynthesis:
                    PrintBatchSynthesisActionUsage(action, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintProjectActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "project get";
                    description = "Gets the list of projects for the authenticated subscription.";
                    sampleCommand = "CustomVoice-API project get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.create:
                    actionString = "project create";
                    description = "Creates a new project.";
                    sampleCommand = "CustomVoice-API project create subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test gender Male locale en-US";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "project delete";
                    description = "Deletes the project identified by the given ID.";
                    sampleCommand = "CustomVoice-API project delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintDatasetActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "dataset get";
                    description = "Gets all voice datasets.";
                    sampleCommand = "CustomVoice-API dataset get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.getbyprojectid:
                    actionString = "dataset getbyprojectid";
                    description = "Get the list of datasets for specified project.";
                    sampleCommand = "CustomVoice-API dataset getbyprojectid subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "dataset delete";
                    description = "Deletes the voice dataset with the given id.";
                    sampleCommand = "CustomVoice-API dataset delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ datasetId [DatasetId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.uploaddataset:
                    actionString = "dataset uploaddataset";
                    description = "Uploads data and creates a new voice data object.";
                    sampleCommand = "CustomVoice-API dataset uploaddataset subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test projectId [ProjectId] gender Male locale en-US wavePath C://sample.zip scriptPath C://sample.txt";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.uploaddatasetwithlongaudio:
                    actionString = "dataset uploaddatasetwithlongaudio";
                    description = "Upload voice dataset with long audio and scripts.";
                    sampleCommand = "CustomVoice-API dataset uploaddatasetwithlongaudio subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test projectId [ProjectId] gender Male locale en-US wavePath C://sample.zip scriptPath C://sample.txt";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.uploaddatasetwithaudioonly:
                    actionString = "dataset uploaddatasetwithaudioonly";
                    description = "Upload voice dataset only with audio.";
                    sampleCommand = "CustomVoice-API dataset uploaddatasetwithaudioonly subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test projectId [ProjectId] gender Male locale en-US wavePath C://sample.zip";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintModelActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "model get";
                    description = "Gets a list of voice model details.";
                    sampleCommand = "CustomVoice-API model get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.getbyprojectid:
                    actionString = "model getbyprojectid";
                    description = "Gets the list of models for specified project.";
                    sampleCommand = "CustomVoice-API model getbyprojectid subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.create:
                    actionString = "model create";
                    description = "Creates a new voice model object.";
                    sampleCommand = "CustomVoice-API model create subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test projectId [ProjectId] gender Male locale en-US dataset [DatasetId];[DatasetId] isNeuralTTS false isMixlingual false";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "model delete";
                    description = "Deletes the voice model with the given id.";
                    sampleCommand = "CustomVoice-API model delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ modelId [ModelId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintVoiceTestActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "voicetest get";
                    description = "Gets details of the specified model's voice test.";
                    sampleCommand = "CustomVoice-API voicetest get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ modelId [ModelId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.getbyprojectid:
                    actionString = "voicetest getbyprojectid";
                    description = "Get the list of voice tests for specified project.";
                    sampleCommand = "CustomVoice-API voicetest getbyprojectid subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.create:
                    actionString = "voicetest create";
                    description = "Creates a new voice test.";
                    sampleCommand = "CustomVoice-API voicetest create subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId] modelId [ModelId] script 12345 isSSML false";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "voicetest delete";
                    description = "Deletes the specified voice test.";
                    sampleCommand = "CustomVoice-API voicetest delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ voiceTestId [VoiceTestId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintEndpointActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "endpoint get";
                    description = "Gets a list of voice endpoint details.";
                    sampleCommand = "CustomVoice-API endpoint get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.getbyprojectid:
                    actionString = "endpoint getbyprojectid";
                    description = "Gets the list of endpoints for specified project.";
                    sampleCommand = "CustomVoice-API endpoint getbyprojectid subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ projectId [ProjectId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.create:
                    actionString = "endpoint create";
                    description = "Creates a new voice endpoint object.";
                    sampleCommand = "CustomVoice-API endpoint create subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test locale en-us projectId [ProjectId] modelId [ModelId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "endpoint delete";
                    description = "Delete the specified voice endpoint.";
                    sampleCommand = "CustomVoice-API endpoint delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ endpointId [EndpointId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.call:
                    actionString = "endpoint call";
                    description = "Calling the endpoint to synthesize voice data.";
                    sampleCommand = "CustomVoice-API endpoint call subscriptionKey [YourSubscriptionKey] issuetokenurl https://westus.api.cognitive.microsoft.com/sts/v1.0/issueToken endpointUrl https://westus.voice.speech.microsoft.com/cognitiveservices/v1?deploymentId=xxx-xx-xx-xx-xxxxx voiceName testVoice locale en-US script 12345 outputFile C://test.wav isSSML false";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        public static void PrintBatchSynthesisActionUsage(Action action, Dictionary<string, List<string>> parameters)
        {
            string actionString, description, sampleCommand;

            switch (action)
            {
                case Action.get:
                    actionString = "batchsynthesis get";
                    description = "Gets a list of voice synthesis under the selected subscription.";
                    sampleCommand = "CustomVoice-API batchsynthesis get subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.getvoices:
                    actionString = "batchsynthesis getvoice";
                    description = "Gets a list of supported voices for offline synthesis.";
                    sampleCommand = "CustomVoice-API batchsynthesis getvoice subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.create:
                    actionString = "batchsynthesis create";
                    description = "Creates a new synthesis.";
                    sampleCommand = "CustomVoice-API batchsynthesis create subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ name test description test inputTextPath ./script.txt locale en-US models [ModelId]:[ModelId] outputFormat riff-16khz-16bit-mono-pcm isConcatenateResult false";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                case Action.delete:
                    actionString = "batchsynthesis delete";
                    description = "Deletes the specified voice synthesis task.";
                    sampleCommand = "CustomVoice-API batchsynthesis delete subscriptionKey [YourSubscriptionKey] hostURI https://Westus.cris.ai/ batchSynthesisId [BatchSynthesisId]";
                    PrintActionUsageBase(actionString, description, sampleCommand, parameters);
                    break;
                default:
                    break;
            }
        }

        private static void PrintActionUsageBase(string action, string description, string sampleCommand, Dictionary<string, List<string>> parameters)
        {
            Console.WriteLine("");
            Console.WriteLine($"CustomVoice-API {action}:");
            Console.WriteLine("");
            Console.WriteLine(description);
            Console.WriteLine("");
            Console.WriteLine($"Usage: CustomVoice-API {action} [options]");
            Console.WriteLine("");
            Console.WriteLine("--options");
            Console.WriteLine(" [Required]");
            foreach (var Required in parameters["Required"])
            {
                Console.WriteLine($"     {Required}");
            }
            Console.WriteLine(" [Optional]");
            foreach (var Optional in parameters["Optional"])
            {
                Console.WriteLine($"     {Optional}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Sample command : {sampleCommand}");
            Console.WriteLine("");
            Console.WriteLine("See the link below for a list of ibizastsurl");
            Console.WriteLine("https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech#how-to-get-an-access-token");
            Console.WriteLine("");
            Console.WriteLine("See the link for the output format list.");
            Console.WriteLine("https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech#audio-outputs");
            Console.WriteLine("");
            Console.WriteLine("See the link for more information.");
            Console.WriteLine("https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech");
        }
    }
}
