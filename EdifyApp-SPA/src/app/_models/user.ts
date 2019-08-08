export interface User {
    id: number;
    username: string;
    department: string;
    remainingLeaveDays: number;
    currentOutstandingDuties?: string;
    fillInEmployeeReportsTo?: string;
    leaveCommencingDate?: Date;
    leaveReason?: string;
    numberOfDays?: number;
    returnDate?: Date;
    statusOfCurrentOutstandingDuties?: string;
    takeoverEmployee?: string;
}
