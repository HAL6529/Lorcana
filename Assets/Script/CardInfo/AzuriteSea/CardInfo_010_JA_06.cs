using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_06 : CardInfo
{
    public CardInfo_010_JA_06()
    {
        this.cardNo = "010_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ナヴィーン王子";
        this.cardName2 = "気楽な探検家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
