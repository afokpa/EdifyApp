import { Injectable } from "@angular/core";
import { CanDeactivate } from '@angular/router';
import { LeaveComponent } from '../leave/leave.component';

@Injectable()
export class PreventUnsavedChanges implements CanDeactivate<LeaveComponent> {
    canDeactivate(component: LeaveComponent) {
        if(component.leaveForm.dirty) {
            return confirm('Are you sure you want to continue? Any unsaved changes wll be lost');
        }
        return true;
    }
}