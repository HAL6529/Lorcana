using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_02 : CardInfo
{
    public CardInfo_193_JA_02()
    {
        this.cardNo = "193_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "有能な戦士";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
