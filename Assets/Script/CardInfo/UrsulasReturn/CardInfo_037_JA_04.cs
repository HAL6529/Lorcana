using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_04 : CardInfo
{
    public CardInfo_037_JA_04()
    {
        this.cardNo = "037_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "未熟なるミスティーク";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AngelinaSpikeRicardo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
