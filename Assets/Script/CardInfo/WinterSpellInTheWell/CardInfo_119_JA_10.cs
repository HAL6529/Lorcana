using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_10 : CardInfo
{
    public CardInfo_119_JA_10()
    {
        this.cardNo = "119_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ゴライアス";
        this.cardName2 = "ワイバーン城の守護者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
