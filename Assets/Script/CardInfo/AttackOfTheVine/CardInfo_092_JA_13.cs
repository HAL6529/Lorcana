using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_13 : CardInfo
{
    public CardInfo_092_JA_13()
    {
        this.cardNo = "092_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドクター・ブッシュルート";
        this.cardName2 = "悪の植物学者";
        this.power = 4;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
