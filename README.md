![image](https://user-images.githubusercontent.com/95020313/186171119-c4dbbd69-c16c-4e7d-b30b-ded577587097.png)

## AtomIFC
AtomIFC is an open-source library for merging IFC files, developed and maintained by Qonic.

Currently, the library supports the following:
* C# library with IFC classes, and read/write support.
* Full merge of IFC files: combining IFC objects from different files, while correctly handling all the corresponding relationships, attributes, and properties. 
* Partial merge of IFC files per building story. 
* Owner history: keeping track of how many objects have been added, changed, and removed during merging. 

## Motivation
The AEC industry is highly data-intensive; and is operated in a fragmented, project-based way. The standard practice of designing and constructing buildings involves the creation of multiple models by multiple project participants for different purposes.  

This data is now often locked in proprietary file formats or trapped on some cloud provider server. If a proprietary file format changes, a software is no longer supported, or a cloud service becomes unavailable, data can get lost. This current practice puts data ownership and agency from users at risk.  

Nonetheless, for many AEC professionals, keeping ownership of that data is crucial. Some important aspects of data ownership include long-term archiving of data, and increased privacy and security of the data. Also, data ownership reduces vendor lock-in, allowing users to manipulate data using other software programs, with less dependencies on services provided by one particular vendor.

Making the data external is a great first step to return data ownership to the user. Moreover, on top of this external data layer, several workflow enhancements can be built that are non-existent today.  

* Packaging: Changes in the model can be stored and transmitted in small packages of data, rather than sending across entire monolithic files.  
* Change control: Change control can be used to track changes in the data, used for coordinating work among AEC professionals collaboratively developing models. 
* Versioning: The history of model data can be maintained, with the possibility to make snapshots of a project in time at different milestones. 

### AtomIFC
The goal of AtomIFC is to allow architects, engineers, and other building professionals to work with BIM data as atomized, external objects, which can be packaged, versioned, merged, etc. The library will be made open-source, available under an MIT license, and will remain so forever.

AtomIFC builds on top of the existing Industry Foundation Classes (IFC). IFC is an open standard for exchanging building data models used in building design and construction across different software applications.

AtomIFC starts from the idea to have more granular IFC ‘atoms’ for each model object, which can be exchanged close to real-time exporting just changes, not full monolithic files. For every IFC atom, it is possible to store the relevant history and identification related information (including the corresponding user, the changes made to the object, and time information). 

The result is that data can be exchanged as open, atomized IFC parts, while keeping track of which and when objects have been added, deleted, or modified. AtomIFC can create and merge atomized IFC files and deal with the corresponding history and identification related information.

## Example use case
A typical workflow for AtomIFC is shown in the video below. The initial model is designed in Autodesk Revit, and the first version of model is exported to IFC.

In the next step, another user makes a couple of design changes in the bathroom layout. There is no need to export the entire IFC model again. Only the changed objects (added, modified, or deleted) can be exchanged using a partial IFC export, which is a much smaller package to send across.

AtomIFC is used to re-combine the original model with the changed objects and create the merged IFC file. The owner history of the model changes is maintained in the merged IFC file. The receiving application Qonic can identify the state of changed object and integrate the changes in the internal version history.

https://user-images.githubusercontent.com/95020083/185927638-eebc4591-23ca-4e04-9b35-aa403a9726c3.mp4

## Prerequisites
```
 Git
 Visual Studio 2019/2022
 ```
 
## Getting started
Clone the project.
 
Build and run the project with Visual Studio.

You will be asked to give the location of the directory of the files you want to merge.

![image](https://user-images.githubusercontent.com/95020313/174752275-c4a42464-242c-477c-b694-0f1a4f53af5e.png)


After entering a valid file path, the merging will begin.

All files (except the ones with delete in the filename) are converted to a IfcData object, then all the IfcDataObjects are merged into one.
Duplicates are removed, relations that are spread out in different files are combined and issues with guids being used for mutliple unidentical objects are solved. 


Files with "delete" in their name are flagged for delete, these filenames should also contain the guid of the object that needs to be deleted.
The Guid in the filename will be deleted from the merged IFC file and all the relations to it will be updated.
In case the object that has to be deleted is an aggregate then all its parts will be deleted as well. If it has a Void to element relationship then the IfcOpeningElement will be deleted as well.





Output:

The merged IFC file and the ownerHistoryLog.

![image](https://user-images.githubusercontent.com/95020313/174750293-295be2f6-7e4b-44cd-9296-253e80512e3e.png)

The ownerHistory log gives you an overview of the different ownerhistories that have been found in the files and you can how many objects have been added,changed and removed. 

The result will be added in a "Merged" directory inside the directory you have specified earlier.

## License

Copyright © 2022 Qonic

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
