using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_08 : CardInfo
{
    public CardInfo_046_JA_08()
    {
        this.cardNo = "046_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドルーン";
        this.cardName2 = "貪欲な魔物";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
