using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_08 : CardInfo
{
    public CardInfo_013_JA_08()
    {
        this.cardNo = "013_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ジーン";
        this.cardName2 = "ナイスランドの住人";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
