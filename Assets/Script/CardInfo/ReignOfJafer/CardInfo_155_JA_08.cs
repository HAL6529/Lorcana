using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_08 : CardInfo
{
    public CardInfo_155_JA_08()
    {
        this.cardNo = "155_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アニータ・ラドクリフ";
        this.cardName2 = "愛犬家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
