using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_10 : CardInfo
{
    public CardInfo_190_JA_10()
    {
        this.cardNo = "190_JA_10";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ブロードウェイ";
        this.cardName2 = "強くて頑丈";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KuyaJaypi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
