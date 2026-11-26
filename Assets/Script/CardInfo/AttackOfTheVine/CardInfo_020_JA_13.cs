using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_13 : CardInfo
{
    public CardInfo_020_JA_13()
    {
        this.cardNo = "020_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "つるの専門家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
