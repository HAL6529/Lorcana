using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_13 : CardInfo
{
    public CardInfo_162_JA_13()
    {
        this.cardNo = "162_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "チャールズ・マンツ";
        this.cardName2 = "鳥憑かれた冒険家";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
