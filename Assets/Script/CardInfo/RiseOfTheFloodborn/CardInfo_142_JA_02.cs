using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_02 : CardInfo
{
    public CardInfo_142_JA_02()
    {
        this.cardNo = "142_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "コグスワース";
        this.cardName2 = "大きな古時計";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
