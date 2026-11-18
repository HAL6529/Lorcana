using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_08 : CardInfo
{
    public CardInfo_195_JA_08()
    {
        this.cardNo = "195_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "高みの見物中";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
