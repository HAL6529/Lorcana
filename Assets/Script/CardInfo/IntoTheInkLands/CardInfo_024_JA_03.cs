using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_03 : CardInfo
{
    public CardInfo_024_JA_03()
    {
        this.cardNo = "024_JA_03";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "99ïCÇÌÇÒÇøÇ·ÇÒëÂçsêi";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
