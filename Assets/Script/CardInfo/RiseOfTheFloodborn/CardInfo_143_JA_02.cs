using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_02 : CardInfo
{
    public CardInfo_143_JA_02()
    {
        this.cardNo = "143_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "コグスワース";
        this.cardName2 = "物言う時計";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
