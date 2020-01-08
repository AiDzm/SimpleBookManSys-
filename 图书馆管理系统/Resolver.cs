﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 图书馆管理系统
{

    public class IndustryIdentifiersItem
    {
        public string type { get; set; }
        public string identifier { get; set; }
    }
    public class ReadingModes
    {
        public string text { get; set; }
        public string image { get; set; }
    }
    public class PanelizationSummary
    {
        public string containsEpubBubbles { get; set; }
        public string containsImageBubbles { get; set; }
    }
    public class ImageLinks
    {
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }
    public class VolumeInfo
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public List<string> authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public List<IndustryIdentifiersItem> industryIdentifiers { get; set; }
        public ReadingModes readingModes { get; set; }
        public int pageCount { get; set; }
        public string printType { get; set; }
        public List<string> categories { get; set; }
        public string maturityRating { get; set; }
        public string allowAnonLogging { get; set; }
        public string contentVersion { get; set; }
        public PanelizationSummary panelizationSummary { get; set; }
        public ImageLinks imageLinks { get; set; }
        public string language { get; set; }
        public string previewLink { get; set; }
        public string infoLink { get; set; }
        public string canonicalVolumeLink { get; set; }
    }
    public class SaleInfo
    {
        public string country { get; set; }
        public string saleability { get; set; }
        public string isEbook { get; set; }
    }
    public class Epub
    {
        public string isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }
    public class Pdf
    {
        public string isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }
    public class AccessInfo
    {
        public string country { get; set; }
        public string viewability { get; set; }
        public string embeddable { get; set; }
        public string publicDomain { get; set; }
        public string textToSpeechPermission { get; set; }
        public Epub epub { get; set; }
        public Pdf pdf { get; set; }
        public string webReaderLink { get; set; }
        public string accessViewStatus { get; set; }
        public string quoteSharingAllowed { get; set; }
    }
    public class SearchInfo
    {
        public string textSnippet { get; set; }
    }
    public class ItemsItem
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        public SaleInfo saleInfo { get; set; }
        public AccessInfo accessInfo { get; set; }
        public SearchInfo searchInfo { get; set; }
    }
    public class Root
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<ItemsItem> items { get; set; }
    }
}
