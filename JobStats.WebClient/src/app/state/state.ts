import {JobStat} from "../types/job-stat";

export interface JobStatsStore {
	JobStats: JobStat[];
	numOfDistinctJobs: number
}
