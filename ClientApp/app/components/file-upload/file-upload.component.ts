import { Component, ElementRef, Renderer, Input, HostListener, HostBinding, OnInit } from '@angular/core';
import { FileUploader, FileUploaderOptions, FileSelectDirective } from 'ng2-file-upload';

@Component({
  selector: 'app-file-upload',
  templateUrl: './file-upload.component.html',
  styleUrls: ['./file-upload.component.css']
})
export class FileUploadComponent {
  public uploader:FileUploader = 
        new FileUploader({url: 'http://localhost:5000/'});
  public hasBaseDropZoneOver:boolean = false;
  public hasAnotherDropZoneOver:boolean = false;
  
  public fileOverBase(e:any):void {
    this.hasBaseDropZoneOver = e;
  }
 
  public fileOverAnother(e:any):void {
    this.hasAnotherDropZoneOver = e;
  }
}
