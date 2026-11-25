using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_13 : CardInfo
{
    public CardInfo_146_JA_13()
    {
        this.cardNo = "146_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "マーリン";
        this.cardName2 = "未来を幻視する者";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
