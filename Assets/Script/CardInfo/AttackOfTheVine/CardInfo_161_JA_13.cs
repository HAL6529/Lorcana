using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_13 : CardInfo
{
    public CardInfo_161_JA_13()
    {
        this.cardNo = "161_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "不審がる不寝番";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AurelieLise_Anne;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
