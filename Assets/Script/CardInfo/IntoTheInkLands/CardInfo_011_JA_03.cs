using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_03 : CardInfo
{
    public CardInfo_011_JA_03()
    {
        this.cardNo = "011_JA_03";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ミスター・スヌープス";
        this.cardName2 = "役立たずなビジネスマン";
        this.power = 4;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
