using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_03 : CardInfo
{
    public CardInfo_108_JA_03()
    {
        this.cardNo = "108_JA_03";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ƒqƒ…ƒhƒ‰";
        this.cardName2 = "‘åŽÖ‚Ì‰ö•¨";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
