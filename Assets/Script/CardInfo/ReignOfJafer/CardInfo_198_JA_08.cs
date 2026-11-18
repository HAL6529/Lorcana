using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_08 : CardInfo
{
    public CardInfo_198_JA_08()
    {
        this.cardNo = "198_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ナマーリ";
        this.cardName2 = "一本気な宿敵";
        this.power = 0;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
