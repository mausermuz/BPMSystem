export class ViewModelCreateEmployee{
  constructor(public firstName?: string,
              public lastName?: string,
              public dateOfBirth?: Date,
              public ediData?: Date,
              public workExperience?: number,
              public personNumber?: string,
              public positionId?: number,
              public departmentId?: number) {
  }
}