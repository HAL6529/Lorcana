using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_05 : CardInfo
{
    public CardInfo_141_JA_05()
    {
        this.cardNo = "141_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プリンス・ジョン";
        this.cardName2 = "虎視眈々な贈賄者";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
