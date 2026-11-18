using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_08 : CardInfo
{
    public CardInfo_070_JA_08()
    {
        this.cardNo = "070_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "あなたのためよ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoelDuQue;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
