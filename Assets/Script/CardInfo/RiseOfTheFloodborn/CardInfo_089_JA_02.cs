using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_02 : CardInfo
{
    public CardInfo_089_JA_02()
    {
        this.cardNo = "089_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "プリンス・ジョン";
        this.cardName2 = "強欲王";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
