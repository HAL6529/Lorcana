using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_213_JA_03 : CardInfo
{
    public CardInfo_213_JA_03()
    {
        this.cardNo = "213_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒNƒXƒR‚Ì‹{“a";
        this.cardName2 = "‰¤—l‚Ì‰Æ";
        this.power = 3;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreasRocha;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Enchanted;
    }
}
