using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_02 : CardInfo
{
    public CardInfo_008_JA_02()
    {
        this.cardNo = "008_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ガストン";
        this.cardName2 = "バリトンの威張り屋";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
