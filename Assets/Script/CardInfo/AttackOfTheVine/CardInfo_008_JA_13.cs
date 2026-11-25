using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_13 : CardInfo
{
    public CardInfo_008_JA_13()
    {
        this.cardNo = "008_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "プリヤ・マンガル";
        this.cardName2 = "音楽ガチ勢";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiegoMachuca;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
