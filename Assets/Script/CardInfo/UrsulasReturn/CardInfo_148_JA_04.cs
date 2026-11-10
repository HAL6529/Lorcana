using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_04 : CardInfo
{
    public CardInfo_148_JA_04()
    {
        this.cardNo = "148_JA_04";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ジョン・シルバー";
        this.cardName2 = "宙域の恐怖";
        this.power = 8;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
