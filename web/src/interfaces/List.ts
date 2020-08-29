﻿export interface List {
  id: number;
  name: string;
  description: string;
  licenseId: number;
  syntaxIds: number[];
  languageIso6391s: number[];
  tagIds: number[];
  maintainerIds: number[];

  // auto-generated by useLists hook
  slug: string;
}
