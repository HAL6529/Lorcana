using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_10 : CardInfo
{
    public CardInfo_120_JA_10()
    {
        this.cardNo = "120_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ブルックリン";
        this.cardName2 = "副司令官";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
