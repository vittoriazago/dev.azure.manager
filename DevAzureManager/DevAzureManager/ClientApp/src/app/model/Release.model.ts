export class Release {
    /**
     *
     */
    constructor() {
    }

    count: number;
    value: ReleaseIn[];
}

export class ReleaseIn {
    /**
     *
     */
    constructor() {
    }

    id: number;
    revision: number;
    createdOn: string;
    modifiedOn: string;
    status: number;
    releaseId: number;
    releaseName: string;
    releaseDefinitionId: number;
    releaseDefinitionName: string;
    releaseEnviromentName: string;
    createdBy: string;
    branch: string;
}
